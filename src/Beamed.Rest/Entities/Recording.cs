using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Recording : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("channelId")]
    public uint ChannelId { get; private set; }

    [JsonProperty("state")]
    public string State { get; private set; }

    [JsonProperty("viewsTotal")]
    public uint ViewsTotal { get; private set; }

    [JsonProperty("expiresAt")]
    public string ExpiresAt { get; private set; }

    [JsonProperty("vods")]
    public Vod[] Vods { get; private set; }

    [JsonProperty("viewed")]
    public bool? Viewed { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("typeId")]
    public uint TypeId { get; private set; }

    [JsonProperty("duration")]
    public double Duration { get; private set; }

    [JsonProperty("seen")]
    public bool? Seen { get; private set; }
  }
}
