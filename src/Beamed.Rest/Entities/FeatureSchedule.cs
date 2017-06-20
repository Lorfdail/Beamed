using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class FeatureSchedule : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("startedAt")]
    public string StartedAt { get; private set; }

    [JsonProperty("endedAt")]
    public string EndedAt { get; private set; }

    [JsonProperty("type")]
    public string Type { get; private set; }

    [JsonProperty("userId")]
    public uint? UserId { get; private set; }

    [JsonProperty("channelId")]
    public string ChannelId { get; private set; }
  }
}
