using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class GameTypeSimple : IEntity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }
    
    [JsonProperty("coverUrl")]
    public string CoverUrl { get; private set; }
    
    [JsonProperty("backgroundUrl")]
    public string BackgroundUrl { get; private set; }
  }
}
