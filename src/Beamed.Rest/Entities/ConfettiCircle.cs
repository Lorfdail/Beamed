using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ConfettiCircle : IConfettiShape {
    new public string Shape = "circle";

    [JsonProperty(PropertyName = "size")]
    public string Size { get; private set; }

    [JsonProperty(PropertyName = "flipPeriod")]
    public string FlipPeriod { get; private set; }

    [JsonProperty(PropertyName = "colors")]
    public ConfettiColor[] Colors { get; private set; }
  }
}
