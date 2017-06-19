using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class FrontendVersion : IEntity {
    [JsonProperty(PropertyName = "version")]
    public string Version { get; private set; }

    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; private set; }
  }
}
