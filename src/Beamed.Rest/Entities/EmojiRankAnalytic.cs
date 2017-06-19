using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class EmojiRankAnalytic : IEntity {
    [JsonProperty(PropertyName = "channel")]
    public uint Channel { get; private set; }

    [JsonProperty(PropertyName = "emoji")]
    public string Emoji { get; private set; }

    [JsonProperty(PropertyName = "count")]
    public uint Count { get; private set; }

    [JsonProperty(PropertyName = "time")]
    public string Time { get; private set; }
  }
}
