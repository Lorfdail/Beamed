using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class LanguageCount : Entity {
    [JsonProperty("id")]
    public string RFC5646Id { get; private set; }

    [JsonProperty("count")]
    public uint Count { get; private set; }
  }
}
