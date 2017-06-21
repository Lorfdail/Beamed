using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Rating : Entity {
    [JsonProperty("id")]
    public string Id { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("logoUrl")]
    public string LogoUrl { get; private set; }
  }
}
