using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class TranscodingProfileTranscode : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("title")]
    public string Title { get; private set; }

    [JsonProperty("width")]
    public uint Width { get; private set; }

    [JsonProperty("height")]
    public uint Height { get; private set; }

    [JsonProperty("bitrate")]
    public uint Bitrate { get; private set; }

    [JsonProperty("fps")]
    public uint FPS { get; private set; }

    [JsonProperty("requitesPartner")]
    public bool RequiresPartner { get; private set; }
  }
}
