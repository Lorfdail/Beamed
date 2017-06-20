using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class CostreamLayout : Entity {
    [JsonProperty(PropertyName = "name")]
    public string Name { get; private set; }

    [JsonProperty(PropertyName = "order")]
    public double[] order { get; private set; }
  }
}
