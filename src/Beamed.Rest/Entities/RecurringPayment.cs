using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class RecurringPayment : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("type")]
    public string Type { get; private set; }

    [JsonProperty("relid")]
    public uint RelId { get; private set; }

    [JsonProperty("status")]
    public string Status { get; private set; }

    [JsonProperty("cancelled")]
    public bool Cancelled { get; private set; }

    [JsonProperty("gateway")]
    public string Gateway { get; private set; }

    [JsonProperty("timesPaid")]
    public uint TimesPaid { get; private set; }

    [JsonProperty("user")]
    public uint UserId { get; private set; }
  }
}
