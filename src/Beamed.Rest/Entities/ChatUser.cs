using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ChatUser : Entity {
    [JsonProperty(PropertyName = "userId")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "userName")]
    public string Name { get; private set; }

    [JsonProperty(PropertyName = "userRoles")]
    public string[] Roles { get; private set; }

    [JsonProperty(PropertyName = "lurking")]
    public bool? Lurking { get; private set; }
  }
}
