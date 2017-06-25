using Beamed.Rest.Entities.Channels;
using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class UserWithChannel : User {
    [JsonProperty("channel")]
    public Channel Channel { get; private set; }
  }
}
