using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class RestGameTypeSimple {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; private set; }
    
    [JsonProperty(PropertyName = "coverUrl")]
    public string CoverUrl { get; private set; }
    
    [JsonProperty(PropertyName = "backgroundUrl")]
    public string BackgroundUrl { get; private set; }
  }

  public class GameTypeLookup {
    [JsonProperty(PropertyName = "exact")]
    public bool Exact { get; private set; }
  }

  public class RestGameType : RestGameTypeSimple {
    [JsonProperty(PropertyName = "parent")]
    public string Parent { get; private set; }
    
    [JsonProperty(PropertyName = "description")]
    public string Description { get; private set; }
    
    [JsonProperty(PropertyName = "source")]
    public string Source { get; private set; }
    
    [JsonProperty(PropertyName = "viewersCurrent")]
    public uint ViewersCurrent { get; private set; }
    
    [JsonProperty(PropertyName = "online")]
    public bool Online { get; private set; }
  }
}
