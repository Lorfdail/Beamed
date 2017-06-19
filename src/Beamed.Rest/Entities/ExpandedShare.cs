using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ExpendedShare : Share {
    [JsonProperty(PropertyName = "user")]
    public User User { get; private set; }
  }
}
