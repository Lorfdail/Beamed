using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class FollowersAnalytic : Entity {
    [JsonProperty("channel")]
    public uint Channel { get; private set; }

    [JsonProperty("total")]
    public uint Total { get; private set; }

    [JsonProperty("delta")]
    public double Delta { get; private set; }

    [JsonProperty("user")]
    public uint? UserId { get; private set; }

    [JsonProperty("time")]
    public string Time { get; private set; }
  }
}
