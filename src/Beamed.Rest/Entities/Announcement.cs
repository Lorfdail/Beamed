using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Announcement : IEntity {
    [JsonProperty(PropertyName = "text")]
    public string Text { get; private set; }

    [JsonProperty(PropertyName = "script")]
    public string Script { get; private set; }

    [JsonProperty(PropertyName = "scope")]
    public object Scope { get; private set; }
  }
}
