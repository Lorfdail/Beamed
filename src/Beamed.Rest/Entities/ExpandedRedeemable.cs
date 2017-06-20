using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ExpandedRedeemable : Redeemable {
    [JsonProperty("owner")]
    public User Owner { get; private set; }

    [JsonProperty("redeemedBy")]
    public User RedeemedBy { get; private set; }
  }
}
