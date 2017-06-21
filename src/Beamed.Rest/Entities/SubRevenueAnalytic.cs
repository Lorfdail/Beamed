using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class SubRevenueAnalytic : Entity {
    [JsonProperty("channel")]
    public uint Channel { get; private set; }

    [JsonProperty("gateway")]
    public string Gateway { get; private set; }

    [JsonProperty("total")]
    public double Total { get; private set; }

    [JsonProperty("gross")]
    public double Gross { get; private set; }

    [JsonProperty("count")]
    public uint Count { get; private set; }
  }
}
