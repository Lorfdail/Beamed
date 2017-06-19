using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Follow : TimeStamp {
    [JsonProperty(PropertyName = "user")]
    public uint UserId { get; private set; }

    [JsonProperty(PropertyName = "channel")]
    public uint ChannelId { get; private set; }
  }
}
