using Newtonsoft.Json;

namespace Beamed.Rest.Entities.Channels {
  public class DetailChannel : Channel {
    [JsonProperty("streamKey")]
    public string StreamKey { get; private set; }
    
    [JsonProperty("numSubscribers")]
    public uint NumSubscribers { get; private set; }

    [JsonProperty("maxConcurrentSubscribers")]
    public uint MaxConcurrentSubscribers { get; private set; }

    [JsonProperty("totalUniqueSubscribers")]
    public uint TotalUniqueSubscribers { get; private set; }
  }
}
