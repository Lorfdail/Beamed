using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ChatUser : IEntity {
    [JsonProperty("userId")]
    public uint Id { get; private set; }

    [JsonProperty("userName")]
    public string Name { get; private set; }

    [JsonProperty("userRoles")]
    public string[] Roles { get; private set; }

    [JsonProperty("lurking")]
    public bool? Lurking { get; private set; }
  }
}
