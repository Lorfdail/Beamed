using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Subscription : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("resourceId")]
    public uint? ResourceId { get; private set; }

    [JsonProperty("resourceType")]
    public string ResourceType { get; private set; }

    [JsonProperty("status")]
    public string Status { get; private set; }

    [JsonProperty("cancelled")]
    public bool Cancelled { get; private set; }

    [JsonProperty("expiresAt")]
    public string ExpiresAt { get; private set; }
  }
}
