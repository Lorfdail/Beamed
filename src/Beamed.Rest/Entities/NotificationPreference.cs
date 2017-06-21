using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class LiveNotification {
    [JsonProperty("channelId")]
    public object ChannelId { get; private set; }

    [JsonProperty("kind")]
    public string[] Kind { get; private set; }
  }

  public class NotificationPreference : Entity {
    [JsonProperty("id")]
    public string Id { get; private set; }

    [JsonProperty("alllowsEmailMarketing")]
    public bool AllowsEmailMarketing { get; private set; }

    [JsonProperty("notifyFollower")]
    public string[] NotifyFollower { get; private set; }

    [JsonProperty("notifySubscriber")]
    public string[] NotifySubscriber { get; private set; }

    [JsonProperty("liveOnByDefault")]
    public string[] LiveOnByDefault { get; private set; }

    [JsonProperty("lastRead")]
    public string LastRead { get; private set; }

    [JsonProperty("liveNotifications")]
    public LiveNotification[] LiveNotifications { get; private set; }

    [JsonProperty("transports")]
    public object[] Transports { get; private set; }
  }
}
