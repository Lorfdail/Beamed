using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Achievement : Entity {
    [JsonProperty(PropertyName = "slug")]
    public string Slug { get; private set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; private set; }

    [JsonProperty(PropertyName = "description")]
    public string Description { get; private set; }

    [JsonProperty(PropertyName = "sparks")]
    public uint Sparks { get; private set; }
  }
}
