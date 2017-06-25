using Beamed.Rest.Entities.Channels;
using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class PrivateTwoFactor {
    [JsonProperty("enabled")]
    public bool Enabled { get; private set; }
  }

  public class PrivatePopulatedUser : PrivateUser {
    [JsonProperty("channel")]
    public Channel Channel { get; private set; }

    [JsonProperty("groups")]
    public UserGroup[] Groups { get; private set; }

    [JsonProperty("preferences")]
    public UserPreferences Preferences { get; private set; }

    [JsonProperty("twoFactor")]
    public new PrivateTwoFactor TwoFactor { get; private set; }
  }
}
