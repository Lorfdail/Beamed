using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Announcement : IEntity {
    [JsonProperty("text")]
    public string Text { get; private set; }

    [JsonProperty("script")]
    public string Script { get; private set; }

    [JsonProperty("scope")]
    public object Scope { get; private set; }
  }
}
