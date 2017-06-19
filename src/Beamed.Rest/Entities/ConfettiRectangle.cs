using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ConfettiRectangle : IConfettiShape {
    new public string Shape = "rectangle";

    [JsonProperty(PropertyName = "width")]
    public string Width { get; private set; }

    [JsonProperty(PropertyName = "height")]
    public string Height { get; private set; }

    [JsonProperty(PropertyName = "flipPeriod")]
    public string FlipPeriod { get; private set; }

    [JsonProperty(PropertyName = "colors")]
    public ConfettiColor[] Colors { get; private set; }
  }
}
