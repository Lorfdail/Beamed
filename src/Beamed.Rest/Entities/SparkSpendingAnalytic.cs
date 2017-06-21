using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class SparkSpendingAnalytic : Entity {
    [JsonProperty("channel")]
    public uint ChannelId { get; private set; }

    [JsonProperty("sparks")]
    public double Sparks { get; private set; }

    [JsonProperty("user")]
    public uint UserId { get; private set; }

    [JsonProperty("time")]
    public string Time { get; private set; }
  }
}
