using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class RestResource {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "type")]
    public string Type { get; private set; }

    [JsonProperty(PropertyName = "relid")]
    public uint RelId { get; private set; }

    [JsonProperty(PropertyName = "url")]
    public string Url { get; private set; }

    [JsonProperty(PropertyName = "store")]
    public string Store { get; private set; }

    [JsonProperty(PropertyName = "remotePath")]
    public string RemotePath { get; private set; }

    [JsonProperty(PropertyName = "meta")]
    public object Level { get; private set; }
  }
}
