using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class SessionMeta {
    [JsonProperty("device")]
    public string Device { get; private set; }

    [JsonProperty("client")]
    public string Client { get; private set; }

    [JsonProperty("cversion")]
    public string ClientVersion { get; private set; }

    [JsonProperty("os")]
    public string OS { get; private set; }
  }

  public class Session : Entity {
    [JsonProperty("expires")]
    public uint Expires { get; private set; }

    [JsonProperty("meta")]
    public SessionMeta Meta { get; private set; }

    [JsonProperty("ip")]
    public string Ip { get; private set; }

    [JsonProperty("id")]
    public string Id { get; private set; }
  }
}
