using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class RedeemablePartner : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("redeemableId")]
    public uint RedeemableId { get; private set; }

    [JsonProperty("partnerId")]
    public uint PartnerId { get; private set; }
  }
}
