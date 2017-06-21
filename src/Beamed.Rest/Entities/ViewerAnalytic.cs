using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ViewerAnalytic : Entity {
    [JsonProperty("channel")]
    public uint Channel { get; private set; }

    [JsonProperty("anon")]
    public uint Anon { get; private set; }

    [JsonProperty("authed")]
    public uint Authed { get; private set; }

    [JsonProperty("time")]
    public string Time { get; private set; }
  }
}
