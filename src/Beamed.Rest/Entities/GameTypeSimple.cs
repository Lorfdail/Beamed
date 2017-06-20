using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class GameTypeSimple : Entity {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; private set; }
    
    [JsonProperty(PropertyName = "coverUrl")]
    public string CoverUrl { get; private set; }
    
    [JsonProperty(PropertyName = "backgroundUrl")]
    public string BackgroundUrl { get; private set; }
  }
}
