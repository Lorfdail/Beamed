using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class InteractiveControllerCoords {
    [JsonProperty("mean")]
    public bool Mean { get; private set; }

    [JsonProperty("stdDev")]
    public bool StandardDerivation { get; private set; }
  }

  public class InteractiveJoyStickAnalysis : Entity {
    [JsonProperty("coords")]
    public InteractiveControllerCoords Coordinations { get; private set; }
  }
}
