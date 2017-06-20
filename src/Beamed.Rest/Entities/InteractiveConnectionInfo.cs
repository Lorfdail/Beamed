using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class InteractiveConnectionInfo : IEntity {
    [JsonProperty("address")]
    public string Address { get; private set; }

    [JsonProperty("key")]
    public string Key { get; private set; }

    [JsonProperty("influence")]
    public double Influence { get; private set; }

    [JsonProperty("version")]
    public InteractiveVersion Version { get; private set; }
  }
}
