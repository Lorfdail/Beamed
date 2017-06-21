using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Language : Entity {
    [JsonProperty("id")]
    public string RFC5646Id { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }
  }
}
