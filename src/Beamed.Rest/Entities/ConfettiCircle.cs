using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ConfettiCircle : IConfettiShape {
    new public string Shape = "circle";

    [JsonProperty("size")]
    public string Size { get; private set; }

    [JsonProperty("flipPeriod")]
    public string FlipPeriod { get; private set; }

    [JsonProperty("colors")]
    public ConfettiColor[] Colors { get; private set; }
  }
}
