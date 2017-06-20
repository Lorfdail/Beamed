using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class CostreamLayout : Entity {
    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("order")]
    public double[] order { get; private set; }
  }
}
