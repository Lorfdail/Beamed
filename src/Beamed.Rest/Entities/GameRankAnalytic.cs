using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class GameRankAnalytic : IEntity {
    [JsonProperty(PropertyName = "channel")]
    public uint Channel { get; private set; }

    [JsonProperty(PropertyName = "streams")]
    public uint Streams { get; private set; }

    [JsonProperty(PropertyName = "views")]
    public uint Views { get; private set; }

    [JsonProperty(PropertyName = "shared")]
    public uint Shared { get; private set; }

    [JsonProperty(PropertyName = "time")]
    public string Time { get; private set; }
  }
}
