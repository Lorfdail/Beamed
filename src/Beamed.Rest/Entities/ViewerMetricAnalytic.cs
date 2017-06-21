using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ViewerMetricAnalytic : Entity {
    [JsonProperty("channel")]
    public uint Channel { get; private set; }

    [JsonProperty("country")]
    public string Country { get; private set; }

    [JsonProperty("browser")]
    public string Browser { get; private set; }

    [JsonProperty("platform")]
    public string Platform { get; private set; }

    [JsonProperty("time")]
    public string Time { get; private set; }
  }
}
