using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Follow : TimeStamp {
    [JsonProperty("user")]
    public uint UserId { get; private set; }

    [JsonProperty("channel")]
    public uint ChannelId { get; private set; }
  }
}
