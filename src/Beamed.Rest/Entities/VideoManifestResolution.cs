using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class VideoManifestResolution : Entity {
    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("slug")]
    public string Slug { get; private set; }

    [JsonProperty("width")]
    public uint? Width { get; private set; }

    [JsonProperty("height")]
    public uint? Height { get; private set; }

    [JsonProperty("hasVideo")]
    public bool HasVideo { get; private set; }

    [JsonProperty("bitrate")]
    public uint Bitrate { get; private set; }
  }
}
