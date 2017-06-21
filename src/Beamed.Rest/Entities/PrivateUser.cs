using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class TwoFactor {
    [JsonProperty("enabled")]
    public bool Enabled { get; private set; }

    [JsonProperty("codesViewed")]
    public bool CodesViewed { get; private set; }
  }

  public class PrivateUser : User {
    [JsonProperty("email")]
    public new string Email { get; private set; }

    [JsonProperty("password")]
    public string Password { get; private set; }

    [JsonProperty("twoFactor")]
    public TwoFactor TwoFactor { get; private set; }
  }
}
