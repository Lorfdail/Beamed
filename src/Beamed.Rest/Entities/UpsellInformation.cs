using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class UpsellInformation : Entity {
    [JsonProperty("productId")]
    public string ProductId { get; private set; }

    [JsonProperty("title")]
    public string Title { get; private set; }

    [JsonProperty("boxArtUrl")]
    public string BoxArtUrl { get; private set; }

    [JsonProperty("description")]
    public string Description { get; private set; }

    [JsonProperty("price")]
    public string Price { get; private set; }

    [JsonProperty("ratings")]
    public string[] Ratings { get; private set; }

    [JsonProperty("link")]
    public string Link { get; private set; }
  }
}
