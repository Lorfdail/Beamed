using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class GameType : GameTypeSimple {
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