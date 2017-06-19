using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class CPMAnalytic : IEntity {
    [JsonProperty(PropertyName = "channel")]
    public uint ChannelId { get; private set; }

    [JsonProperty(PropertyName = "impressions")]
    public uint Impressions { get; private set; }

    [JsonProperty(PropertyName = "payout")]
    public double Payout { get; private set; }
  }
}
