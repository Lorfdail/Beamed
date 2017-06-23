using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 

namespace Beamed.Constellation {
  public static class ConstellationMethods {
    public static Task LiveSubscribe(ClientWebSocket ws, string eventName) {
      var parameters = new Dictionary<string, JToken>();
      var names = new JArray();

      names.Add(eventName);
      parameters.Add("events", names);

      var call = new MethodPacket {
        Method = "livesubscribe",
        Parameters = parameters,
        Id = 0
      };

      var json = JsonConvert.SerializeObject(call);
      var bin = new ArraySegment<byte>(Encoding.UTF8.GetBytes(json));

      return ws.SendAsync(bin, WebSocketMessageType.Text, true, CancellationToken.None);
    }
  }
}
