using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class CPMAnalytic : IEntity {
    [JsonProperty("channel")]
    public uint ChannelId { get; private set; }

    [JsonProperty("impressions")]
    public uint Impressions { get; private set; }

    [JsonProperty("payout")]
    public double Payout { get; private set; }
  }
}
