using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.WebSockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Beamed.Core;

namespace Beamed.Constellation {
  public class MixerConstellationClient : MixerClient, IDisposable {
    private ClientWebSocket _ws = new ClientWebSocket();
    private Dictionary<string, List<Action<JObject>>> _listeners = new Dictionary<string, List<Action<JObject>>>();
    private Queue<string> _waitingSubscriptions = new Queue<string>();

    private byte[] _receiveBuffer = new byte[2048];

    public ClientWebSocket WS {
      get => _ws;
    }
    public bool Connected {
      get => _ws.State == WebSocketState.Open;
    }
    public bool Bot = true;
    public bool Greeted { get; private set; } = false;
    public new bool Authenticated { get; private set; } = false;

    public delegate void OnHelloHandler(JObject data);
    public event OnHelloHandler OnHello;

    public void SubscribeToLiveEvent(string eventName, Action<JObject> action) {
      if (!_listeners.ContainsKey(eventName)) {
        _listeners.Add(eventName, new List<Action<JObject>>());
      }
  
      _listeners[eventName].Add(action);
      _waitingSubscriptions.Enqueue(eventName);
    }

    public Task ConnectAsync() =>
      ConnectAsync(CancellationToken.None);

    public Task ConnectAsync(CancellationToken token) {
      _ws.Options.SetRequestHeader("x-is-bot", Bot ? "true" : "false");

      return _ws.ConnectAsync(new Uri(MixerConstants.WSS), token);;
    }

    public Task<Packet> AwaitNextPacket() =>
      AwaitNextPacket(CancellationToken.None);

    public async Task<Packet> AwaitNextPacket(CancellationToken token) {
      var seg = new ArraySegment<byte>(_receiveBuffer);
      var result = await _ws.ReceiveAsync(seg, token);
      var json = Encoding.UTF8.GetString(seg.Array, seg.Offset, result.Count);

      var packet = JsonConvert.DeserializeObject<Packet>(json);

      switch (packet.Type) {
        case "reply":
          return JsonConvert.DeserializeObject<ReplyPacket>(json);

        case "event":
          return JsonConvert.DeserializeObject<EventPacket>(json);

        default: return packet;
      }
    }

    public Task WSLoop() =>
      WSLoop(CancellationToken.None);

    public async Task WSLoop(CancellationToken token) {
      while (Connected) {
        while (_waitingSubscriptions.Count != 0) {
          await ConstellationMethods.LiveSubscribe(this._ws, _waitingSubscriptions.Dequeue());
        }

        var packet = await AwaitNextPacket(token);

        if (packet.IsEvent) {
          var ev = (EventPacket) packet;

          if (ev.Event == "hello") {
            Greeted = true;
            Authenticated = ev.Data.GetValue("authenticated").Value<bool>();

            OnHello(ev.Data);

            continue;
          }

          List<Action<JObject>> listeners;
          _listeners.TryGetValue(ev.Event, out listeners);

          if (listeners != null) {
            listeners.ForEach((listener) => listener(ev.Data));
          }
        }
      }
    }

    public new void Dispose() {
      _ws.Dispose();
      base.Dispose();
    }
  }
}
