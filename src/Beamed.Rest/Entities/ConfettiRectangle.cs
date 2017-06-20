using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ConfettiRectangle : IConfettiShape {
    new public string Shape = "rectangle";

    [JsonProperty("width")]
    public string Width { get; private set; }

    [JsonProperty("height")]
    public string Height { get; private set; }

    [JsonProperty("flipPeriod")]
    public string FlipPeriod { get; private set; }

    [JsonProperty("colors")]
    public ConfettiColor[] Colors { get; private set; }
  }
}
