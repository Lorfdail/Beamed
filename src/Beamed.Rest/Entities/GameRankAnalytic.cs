using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class GameRankAnalytic : IEntity {
    [JsonProperty("channel")]
    public uint Channel { get; private set; }

    [JsonProperty("streams")]
    public uint Streams { get; private set; }

    [JsonProperty("views")]
    public uint Views { get; private set; }

    [JsonProperty("shared")]
    public uint Shared { get; private set; }

    [JsonProperty("time")]
    public string Time { get; private set; }
  }
}
