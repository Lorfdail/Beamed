using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class SocialInfo : Entity {
    [JsonProperty("twitter")]
    public string Twitter { get; private set; }

    [JsonProperty("facebook")]
    public string Facebook { get; private set; }

    [JsonProperty("youtube")]
    public string Youtube { get; private set; }

    [JsonProperty("player")]
    public string PlayerMe { get; private set; }

    [JsonProperty("discord")]
    public string Discord { get; private set; }

    [JsonProperty("verified")]
    public string[] Verified { get; private set; }
  }
}
