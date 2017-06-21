using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Redeemable : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("ownerId")]
    public uint OwnerId { get; private set; }

    [JsonProperty("state")]
    public string State { get; private set; }

    [JsonProperty("type")]
    public string Type { get; private set; }

    [JsonProperty("code")]
    public string Code { get; private set; }

    [JsonProperty("redeemedById")]
    public uint RedeemedById { get; private set; }

    [JsonProperty("redeemedAt")]
    public string RedeemedAt { get; private set; }

    [JsonProperty("meta")]
    public object Meta { get; private set; }
  }
}
