using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Achievement : Entity {
    [JsonProperty("slug")]
    public string Slug { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("description")]
    public string Description { get; private set; }

    [JsonProperty("sparks")]
    public uint Sparks { get; private set; }
  }
}
