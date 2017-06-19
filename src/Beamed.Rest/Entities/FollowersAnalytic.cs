using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class FollowersAnalytic : IEntity {
    [JsonProperty(PropertyName = "channel")]
    public uint Channel { get; private set; }

    [JsonProperty(PropertyName = "total")]
    public uint Total { get; private set; }

    [JsonProperty(PropertyName = "delta")]
    public double Delta { get; private set; }

    [JsonProperty(PropertyName = "user")]
    public uint? UserId { get; private set; }

    [JsonProperty(PropertyName = "time")]
    public string Time { get; private set; }
  }
}
