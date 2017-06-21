using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Invoice : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("currency")]
    public string Currency { get; private set; }

    [JsonProperty("status")]
    public string Status { get; private set; }

    [JsonProperty("user")]
    public uint UserId { get; private set; }

    [JsonProperty("createdAt")]
    public string CreatedAt { get; private set; }

    [JsonProperty("amount")]
    public double Amount { get; private set; }

    [JsonProperty("items")]
    public InvoiceItem[] Items { get; private set; }
  }
}
