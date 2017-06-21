using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class InvoiceItem : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("type")]
    public string Type { get; private set; }

    [JsonProperty("relid")]
    public uint? RelId { get; private set; }

    [JsonProperty("description")]
    public string Description { get; private set; }

    [JsonProperty("amount")]
    public double Amount { get; private set; }

    [JsonProperty("quantity")]
    public uint Quantity { get; private set; }

    [JsonProperty("status")]
    public string Status { get; private set; }

    [JsonProperty("user")]
    public uint UserId { get; private set; }

    [JsonProperty("invoice")]
    public uint InvoiceId { get; private set; }
  }
}
