using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class DiscordRole : Entity {
    [JsonProperty("id")]
    public string Id { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("color")]
    public string Color { get; private set; }
  }
}
