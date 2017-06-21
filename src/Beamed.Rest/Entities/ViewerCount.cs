using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ViewerCount : Entity {
    [JsonProperty("time")]
    public string Time { get; private set; }

    [JsonProperty("anon")]
    public uint Anon { get; private set; }

    [JsonProperty("authed")]
    public uint Authed { get; private set; }
  }
}
