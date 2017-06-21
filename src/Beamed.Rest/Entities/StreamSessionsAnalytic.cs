using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class StreamSessionAnalytic : Entity {
    [JsonProperty("channel")]
    public uint Channel { get; private set; }

    [JsonProperty("online")]
    public bool Online { get; private set; }

    [JsonProperty("duration")]
    public uint? Duration { get; private set; }

    [JsonProperty("typeID")]
    public uint? TypeId { get; private set; }

    [JsonProperty("time")]
    public string Time { get; private set; }
  }
}
