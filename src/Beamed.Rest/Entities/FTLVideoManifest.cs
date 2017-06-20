using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class FTLVideoManifest : Entity {
    [JsonProperty("resolutions")]
    public VideoManifestResolution[] Resolutions { get; private set; }

    [JsonProperty("since")]
    public string Since { get; private set; }
  }
}
