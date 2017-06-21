using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class GameType : GameTypeSimple {
    [JsonProperty("parent")]
    public string Parent { get; private set; }
    
    [JsonProperty("description")]
    public string Description { get; private set; }
    
    [JsonProperty("source")]
    public string Source { get; private set; }
    
    [JsonProperty("viewersCurrent")]
    public uint ViewersCurrent { get; private set; }
    
    [JsonProperty("online")]
    public bool Online { get; private set; }
  }
}
