using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class CheckoutItem : IEntity {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "quantity")]
    public uint Quantity { get; private set; }
  }
}
