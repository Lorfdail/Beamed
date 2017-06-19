using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class DiscordBotRole {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "type")]
    public string Type { get; private set; }

    [JsonProperty(PropertyName = "roleId")]
    public string RoleId { get; private set; }

    [JsonProperty(PropertyName = "gracePeriod")]
    public uint? GracePeriod { get; private set; }
  }

  public class DiscordBot : IEntity {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "channelId")]
    public uint ChannelId { get; private set; }

    [JsonProperty(PropertyName = "inviteSetting")]
    public string InviteSetting { get; private set; }

    [JsonProperty(PropertyName = "inviteChannel")]
    public string InviteChannel { get; private set; }

    [JsonProperty(PropertyName = "liveUpdateState")]
    public bool UpdateStatusOnLive { get; private set; }

    [JsonProperty(PropertyName = "liveAnnounceChannel")]
    public bool AnnounceChannelOnLive { get; private set; }

    [JsonProperty(PropertyName = "syncEmoteRoles")]
    public uint[] SyncEmotesRoles { get; private set; }

    [JsonProperty(PropertyName = "roles")]
    public DiscordBotRole[] Roles { get; private set; }
  }
}
