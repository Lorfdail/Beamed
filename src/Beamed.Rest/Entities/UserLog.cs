using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class UserLog : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("userId")]
    public uint UserId { get; private set; }

    [JsonProperty("event")]
    public string Event { get; private set; }

    [JsonProperty("eventData")]
    public object EventData { get; private set; }

    [JsonProperty("source")]
    public string Source { get; private set; }

    [JsonProperty("sourceData")]
    public object SourceData { get; private set; }

    [JsonProperty("createdAt")]
    public string CreatedAt { get; private set; }
  }
}
