using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class OAuthLink : Entity {
    [JsonProperty("service")]
    public string Service { get; private set; }

    [JsonProperty("serviceId")]
    public string ServiceId { get; private set; }

    [JsonProperty("userId")]
    public double UserId { get; private set; }
  }
}
