using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class InteractiveTactileAnalysis {
    [JsonProperty("holding")]
    public bool Holding { get; private set; }

    [JsonProperty("frequency")]
    public bool Frequency { get; private set; }
  }
}
