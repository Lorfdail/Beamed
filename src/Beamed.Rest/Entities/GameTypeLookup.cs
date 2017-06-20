using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class GameTypeLookup : GameTypeSimple {
    [JsonProperty("exact")]
    public bool Exact { get; private set; }
  }
}
