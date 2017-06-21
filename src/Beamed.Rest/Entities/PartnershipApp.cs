using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class PartnershipApp : TimeStamped {
    [JsonProperty("status")]
    public string Status { get; private set; }

    [JsonProperty("reapplies")]
    public string Reapplies { get; private set; }

    [JsonProperty("reason")]
    public string Reason { get; private set; }
  }
}
