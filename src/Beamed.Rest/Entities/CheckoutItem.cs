using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class CheckoutItem : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("quantity")]
    public uint Quantity { get; private set; }
  }
}
