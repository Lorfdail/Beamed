using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ExpandedTranscodingProfile : TranscodingProfile {
    [JsonProperty(PropertyName = "transcodes")]
    public TranscodingProfileTranscode[] Transcodes { get; private set; }
  }
}
