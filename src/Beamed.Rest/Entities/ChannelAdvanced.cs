using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ChannelAdvanced : Channel {
    [JsonProperty(PropertyName = "user")]
    public User User { get; private set; }
    
    [JsonProperty(PropertyName = "type")]
    public GameType Type { get; private set; }
  }
}
