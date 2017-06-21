using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class StreamHostsAnalytic : Entity {
    [JsonProperty("channel")]
    public uint Channel { get; private set; }

    [JsonProperty("hoster")]
    public uint? Hoster { get; private set; }

    [JsonProperty("hostee")]
    public uint? Hostee { get; private set; }

    [JsonProperty("time")]
    public string Time { get; private set; }
  }
}
