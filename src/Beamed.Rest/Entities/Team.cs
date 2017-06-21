using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Team : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("ownerId")]
    public uint OwnerId { get; private set; }

    [JsonProperty("token")]
    public string Token { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("description")]
    public string Description { get; private set; }

    [JsonProperty("logoUrl")]
    public string LogoUrl { get; private set; }

    [JsonProperty("backgroundUrl")]
    public string BackgroundUrl { get; private set; }

    [JsonProperty("social")]
    public SocialInfo Social { get; private set; }
  }
}