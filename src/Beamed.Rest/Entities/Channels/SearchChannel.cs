using Newtonsoft.Json;

namespace Beamed.Rest.Entities.Channels {
  public class SearchChannel : Channel {
    [JsonProperty("thumbnail")]
    public Resource Thumbnail { get; private set; }
    
    [JsonProperty("user")]
    public User User { get; private set; }

    [JsonProperty("type")]
    public GameType Type { get; private set; }
  }
}
