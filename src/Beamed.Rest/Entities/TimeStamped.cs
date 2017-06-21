using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class TimeStamped : Entity {
    [JsonProperty("createdAt")]
    public string CreatedAt { get; private set; }

    [JsonProperty("updatedAt")]
    public string UpdatedAt { get; private set; }

    [JsonProperty("deletedAt")]
    public string DeletedAt { get; private set; }
  }
}
