using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class TranscodingProfile : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }
  }
}
