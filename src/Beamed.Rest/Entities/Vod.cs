using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class VodData {
    [JsonProperty("Width")]
    public uint Width { get; private set; }

    [JsonProperty("Height")]
    public uint Height { get; private set; }

    [JsonProperty("Fps")]
    public double? Fps { get; private set; }

    [JsonProperty("Bitrate")]
    public uint? Bitrate { get; private set; }
  }

  public class Vod : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("baseUrl")]
    public string BaseUrl { get; private set; }

    [JsonProperty("format")]
    public string Format { get; private set; }

    [JsonProperty("data")]
    public VodData Data { get; private set; }

    [JsonProperty("recordingId")]
    public uint RecordingId { get; private set; }
  }
}
