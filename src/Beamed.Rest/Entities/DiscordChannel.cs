using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class DiscordChannel : IEntity {
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; private set; }

    [JsonProperty(PropertyName = "type")]
    public string Type { get; private set; }

    [JsonProperty(PropertyName = "private")]
    public bool Private { get; private set; }
  }
}
