using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class SubscriptionWithGroup : Subscription {
    [JsonProperty("group")]
    public uint Group { get; private set; }

    [JsonProperty("Group")]
    public UserGroup UserGroup { get; private set; }
  }
}
