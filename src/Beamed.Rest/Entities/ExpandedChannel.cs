using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ExpandedChannel : ChannelAdvanced {
    [JsonProperty(PropertyName = "thumbnail")]
    public Resource Thumbnail { get; private set; }

    [JsonProperty(PropertyName = "cover")]
    public Resource Cover { get; private set; }

    [JsonProperty(PropertyName = "badge")]
    public Resource Badge { get; private set; }

    [JsonProperty(PropertyName = "preferences")]
    public ChannelPreferences Preferences { get; private set; }
  }
}
