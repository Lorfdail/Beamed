using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class InteractiveGame : IEntity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("ownerId")]
    public uint OwnerId { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("coverUrl")]
    public string CoverUrl { get; private set; }

    [JsonProperty("description")]
    public string Description { get; private set; }

    [JsonProperty("hasPublishedVersions")]
    public bool HasPublishedVersions { get; private set; }

    [JsonProperty("installation")]
    public string Installation { get; private set; }
  }
}
