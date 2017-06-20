using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class User : Entity {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "level")]
    public uint Level { get; private set; }

    [JsonProperty(PropertyName = "social")]
    public object Social { get; private set; }

    [JsonProperty(PropertyName = "username")]
    public string Username { get; private set; }

    [JsonProperty(PropertyName = "email")]
    public string Email { get; private set; }

    [JsonProperty(PropertyName = "verified")]
    public bool Verified { get; private set; }

    [JsonProperty(PropertyName = "experience")]
    public uint Experience { get; private set; }

    [JsonProperty(PropertyName = "sparks")]
    public uint Sparks { get; private set; }

    [JsonProperty(PropertyName = "avatarUrl")]
    public string AvatarUrl { get; private set; }

    [JsonProperty(PropertyName = "bio")]
    public string Bio { get; private set; }

    [JsonProperty(PropertyName = "primaryTeam")]
    public uint? PrimaryTeam { get; private set; }

    [JsonProperty(PropertyName = "transcodingProfileId")]
    public uint? TranscodingProfileId { get; private set; }

    [JsonProperty(PropertyName = "hasTranscodes")]
    public bool HasTranscodes { get; private set; }
  }
}
