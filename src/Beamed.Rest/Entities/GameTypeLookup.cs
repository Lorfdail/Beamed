using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class GameTypeLookup : GameTypeSimple {
    [JsonProperty(PropertyName = "exact")]
    public bool Exact { get; private set; }
  }
}
