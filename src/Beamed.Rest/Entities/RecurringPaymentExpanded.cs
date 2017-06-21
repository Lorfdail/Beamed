using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class SubscriptionExpanded : Subscription {
    [JsonProperty("user")]
    public User User { get; private set; }

    [JsonProperty("group")]
    public UserGroup Group { get; private set; }
  }

  public class RecurringPaymentExpanded : RecurringPayment {
    [JsonProperty("subscription")]
    public SubscriptionExpanded Subscription { get; private set; }
  }
}
