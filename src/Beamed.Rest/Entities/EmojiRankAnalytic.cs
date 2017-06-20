using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class EmojiRankAnalytic : IEntity {
    [JsonProperty("channel")]
    public uint Channel { get; private set; }

    [JsonProperty("emoji")]
    public string Emoji { get; private set; }

    [JsonProperty("count")]
    public uint Count { get; private set; }

    [JsonProperty("time")]
    public string Time { get; private set; }
  }
}
