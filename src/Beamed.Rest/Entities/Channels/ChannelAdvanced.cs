using Newtonsoft.Json;

namespace Beamed.Rest.Entities.Channels {
  public class ChannelAdvanced : Channel {
    [JsonProperty("user")]
    public User User { get; private set; }
    
    [JsonProperty("type")]
    public GameType Type { get; private set; }
  }
}
