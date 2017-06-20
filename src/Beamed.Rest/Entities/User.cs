using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class User : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("level")]
    public uint Level { get; private set; }

    [JsonProperty("social")]
    public object Social { get; private set; }

    [JsonProperty("username")]
    public string Username { get; private set; }

    [JsonProperty("email")]
    public string Email { get; private set; }

    [JsonProperty("verified")]
    public bool Verified { get; private set; }

    [JsonProperty("experience")]
    public uint Experience { get; private set; }

    [JsonProperty("sparks")]
    public uint Sparks { get; private set; }

    [JsonProperty("avatarUrl")]
    public string AvatarUrl { get; private set; }

    [JsonProperty("bio")]
    public string Bio { get; private set; }

    [JsonProperty("primaryTeam")]
    public uint? PrimaryTeam { get; private set; }

    [JsonProperty("transcodingProfileId")]
    public uint? TranscodingProfileId { get; private set; }

    [JsonProperty("hasTranscodes")]
    public bool HasTranscodes { get; private set; }
  }
}
