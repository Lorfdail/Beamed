using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Resource : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("type")]
    public string Type { get; private set; }

    [JsonProperty("relid")]
    public uint RelId { get; private set; }

    [JsonProperty("url")]
    public string Url { get; private set; }

    [JsonProperty("store")]
    public string Store { get; private set; }

    [JsonProperty("remotePath")]
    public string RemotePath { get; private set; }

    [JsonProperty("meta")]
    public object Meta { get; private set; }
  }
}
