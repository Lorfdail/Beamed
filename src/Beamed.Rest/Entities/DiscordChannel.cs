using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class DiscordChannel : Entity {
    [JsonProperty("id")]
    public string Id { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("type")]
    public string Type { get; private set; }

    [JsonProperty("private")]
    public bool Private { get; private set; }
  }
}
