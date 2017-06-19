using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class DiscordRole : IEntity {
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; private set; }

    [JsonProperty(PropertyName = "color")]
    public string Color { get; private set; }
  }
}
