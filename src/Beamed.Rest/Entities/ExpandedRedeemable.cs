using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ExpandedRedeemable : Redeemable {
    [JsonProperty(PropertyName = "owner")]
    public User Owner { get; private set; }

    [JsonProperty(PropertyName = "redeemedBy")]
    public User RedeemedBy { get; private set; }
  }
}
