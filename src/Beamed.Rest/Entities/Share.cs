using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Share : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("type")]
    public string Type { get; private set; }

    [JsonProperty("relid")]
    public string RelId { get; private set; }

    [JsonProperty("code")]
    public string Code { get; private set; }

    [JsonProperty("userId")]
    public uint? UserId { get; private set; }
  }
}
