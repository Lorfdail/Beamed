using Newtonsoft.Json;

namespace Beamed.Rest.Entities.Channels {
  public class ExpandedChannel : ChannelAdvanced {
    [JsonProperty("thumbnail")]
    public Resource Thumbnail { get; private set; }

    [JsonProperty("cover")]
    public Resource Cover { get; private set; }

    [JsonProperty("badge")]
    public Resource Badge { get; private set; }

    [JsonProperty("preferences")]
    public ChannelPreferences Preferences { get; private set; }
  }
}
