using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class UserGroup : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("type")]
    public string Type { get; private set; }
  }
}
