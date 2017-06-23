using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Beamed.Constellation {
  public class ReplyPacketError {
    [JsonProperty("code")]
    public uint Code { get; private set; }

    [JsonProperty("message")]
    public string Message { get; private set; }
  }

  [JsonObject(MemberSerialization.OptIn)]
  public class Packet {
    [JsonProperty("type")]
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
    [JsonProperty("type")]
    public new string Type = "method";

    [JsonProperty("method")]
    public string Method { get; set; }

    [JsonProperty("params")]
    public Dictionary<string, JToken> Parameters { get; set; }

    [JsonProperty("id")]
    public uint Id { get; set; }
  }

  public class ReplyPacket : Packet {
    [JsonProperty("reply")]
    public object Reply { get; private set; }

    [JsonProperty("error")]
    public ReplyPacketError Error { get; private set; }

    [JsonProperty("id")]
    public uint Id { get; private set; }
  }

  public class EventPacket : Packet {
    [JsonProperty("event")]
    public string Event { get; private set; }

    [JsonProperty("data")]
    public JObject Data { get; private set; }
  }
}
