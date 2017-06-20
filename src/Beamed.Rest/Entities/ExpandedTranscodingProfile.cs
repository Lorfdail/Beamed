using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ExpandedTranscodingProfile : TranscodingProfile {
    [JsonProperty("transcodes")]
    public TranscodingProfileTranscode[] Transcodes { get; private set; }
  }
}
