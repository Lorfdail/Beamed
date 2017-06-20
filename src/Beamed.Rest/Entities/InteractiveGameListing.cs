using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class InteractiveGameListingVersion {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("version")]
    public string Version { get; private set; }

    [JsonProperty("state")]
    public string State { get; private set; }

    [JsonProperty("versionOrder")]
    public uint VersionOrder { get; private set; }
  }

  public class InteractiveGameListing : InteractiveGame {
    [JsonProperty("versions")]
    public InteractiveGameListingVersion[] Versions { get; private set; }

    [JsonProperty("owner")]
    public User Owner { get; private set; }
  }
}
