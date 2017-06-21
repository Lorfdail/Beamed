using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class OAuthClient : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("clientId")]
    public string ClientId { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("website")]
    public string Website { get; private set; }

    [JsonProperty("logo")]
    public string Logo { get; private set; }

    [JsonProperty("hosts")]
    public string[] Hosts { get; private set; }
  }
}
