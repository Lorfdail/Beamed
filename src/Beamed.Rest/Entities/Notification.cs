using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Notification : Entity {
    [JsonProperty("userId")]
    public uint UserId { get; private set; }

    [JsonProperty("sentAt")]
    public string SentAt { get; private set; }

    [JsonProperty("trigger")]
    public string Trigger { get; private set; }

    [JsonProperty("payload")]
    public object Payload { get; private set; }
  }
}
