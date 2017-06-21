using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class UserNotificationPreference {
    [JsonProperty("ids")]
    public string[] Ids { get; private set; }

    [JsonProperty("transports")]
    public string[] Transports { get; private set; }
  }

  public class UserPreferences : Entity {
    [JsonProperty("chat:sounds:html5")]
    public bool? ChatSoundsHtml5 { get; private set; }

    [JsonProperty("chat:sounds:play")]
    public bool? ChatSoundsPlay { get; private set; }

    [JsonProperty("chat:whispers")]
    public bool? ChatWhispers { get; private set; }

    [JsonProperty("chat:timestamps")]
    public bool? ChatTimestamps { get; private set; }

    [JsonProperty("chat:chromakey")]
    public bool? ChatChromakey { get; private set; }

    [JsonProperty("chat:tagging")]
    public bool? ChatTagging { get; private set; }

    [JsonProperty("chat:sounds:volume")]
    public double? ChatSoundsVolume { get; private set; }

    [JsonProperty("chat:colors")]
    public bool? ChatColors { get; private set; }

    [JsonProperty("chat:lurkmode")]
    public bool? ChatLurkMode { get; private set; }

    [JsonProperty("channel:notifications")]
    public UserNotificationPreference ChannelNotifications { get; private set; }

    [JsonProperty("channel:mature:allowed")]
    public bool? ChannelMatureAllowed { get; private set; }

    [JsonProperty("channel:player:forceFlash")]
    public bool? ChannelPlayerForceFlash { get; private set; }
  }
}
