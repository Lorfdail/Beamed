using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class OAuthAuthorization : Entity {
    [JsonProperty("permissions")]
    public string[] Permissions { get; private set; }

    [JsonProperty("userId")]
    public uint UserId { get; private set; }

    [JsonProperty("client")]
    public OAuthClient OAuthClient { get; private set; }
  }
}
