using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class FeatureSchedule : TimeStamped {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "startedAt")]
    public string StartedAt { get; private set; }

    [JsonProperty(PropertyName = "endedAt")]
    public string EndedAt { get; private set; }

    [JsonProperty(PropertyName = "type")]
    public string Type { get; private set; }

    [JsonProperty(PropertyName = "userId")]
    public uint? UserId { get; private set; }

    [JsonProperty(PropertyName = "channelId")]
    public string ChannelId { get; private set; }
  }
}
