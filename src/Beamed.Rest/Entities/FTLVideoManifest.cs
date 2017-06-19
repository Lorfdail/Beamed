using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class FTLVideoManifest : IEntity {
    [JsonProperty(PropertyName = "resolutions")]
    public VideoManifestResolution[] Resolutions { get; private set; }

    [JsonProperty(PropertyName = "since")]
    public string Since { get; private set; }
  }
}
