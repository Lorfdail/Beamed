using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class UserWithGroups : User {
    [JsonProperty("groups")]
    public UserGroup[] Groups { get; private set; }
  }
}
