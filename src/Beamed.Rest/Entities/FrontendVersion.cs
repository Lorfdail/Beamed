using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class FrontendVersion : Entity {
    [JsonProperty("version")]
    public string Version { get; private set; }

    [JsonProperty("displayName")]
    public string DisplayName { get; private set; }
  }
}
