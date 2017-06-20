using System.Collections.Generic;
using Newtonsoft.Json;

namespace Beamed.Constellation {
  public class PacketError {
    [JsonProperty("code")]
    public uint Code { get; private set; }

    [JsonProperty("message")]
    public string Message { get; private set; }
  }

  public abstract class Packet {
    public string Type { get; private set; }

    public bool IsMethod {
      get => Type == "method";
    }

    public bool IsReply {
      get => Type == "reply";
    }

    public bool IsEvent {
      get => Type == "event";
    }
  }

  public class MethodPacket : Packet {
    [JsonProperty("method")]
    public string Method { get; private set; }

    [JsonProperty("params")]
    public Dictionary<string, object> Parameters { get; private set; }

    [JsonProperty("id")]
    public uint Id { get; private set; }
  }

  public class ReplyPacket : Packet {
    [JsonProperty("reply")]
    public object Reply { get; private set; }

    [JsonProperty("error")]
    public PacketError Error { get; private set; }

    [JsonProperty("id")]
    public uint Id { get; private set; }
  }

  public class EventPacket : Packet {
    [JsonProperty("event")]
    public string Event { get; private set; }

    [JsonProperty("data")]
    public object Data { get; private set; }
  }
}
