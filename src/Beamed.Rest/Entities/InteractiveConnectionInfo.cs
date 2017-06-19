using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class InteractiveConnectionInfo {
    [JsonProperty(PropertyName = "address")]
    public string Address { get; private set; }

    [JsonProperty(PropertyName = "key")]
    public string Key { get; private set; }

    [JsonProperty(PropertyName = "influence")]
    public double Influence { get; private set; }

    [JsonProperty(PropertyName = "version")]
    public InteractiveVersion Version { get; private set; }
  }
}
