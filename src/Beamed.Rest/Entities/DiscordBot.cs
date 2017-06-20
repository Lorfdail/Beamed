using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class DiscordBotRole {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("type")]
    public string Type { get; private set; }

    [JsonProperty("roleId")]
    public string RoleId { get; private set; }

    [JsonProperty("gracePeriod")]
    public uint? GracePeriod { get; private set; }
  }

  public class DiscordBot : IEntity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("channelId")]
    public uint ChannelId { get; private set; }

    [JsonProperty("inviteSetting")]
    public string InviteSetting { get; private set; }

    [JsonProperty("inviteChannel")]
    public string InviteChannel { get; private set; }

    [JsonProperty("liveUpdateState")]
    public bool UpdateStatusOnLive { get; private set; }

    [JsonProperty("liveAnnounceChannel")]
    public bool AnnounceChannelOnLive { get; private set; }

    [JsonProperty("syncEmoteRoles")]
    public uint[] SyncEmotesRoles { get; private set; }

    [JsonProperty("roles")]
    public DiscordBotRole[] Roles { get; private set; }
  }
}
