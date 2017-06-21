using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class InteractiveScreenAnalysis {
    [JsonProperty("position")]
    public InteractiveControllerCoords Position { get; private set; }

    [JsonProperty("clicks")]
    public bool Clicks { get; private set; }
  }
}
