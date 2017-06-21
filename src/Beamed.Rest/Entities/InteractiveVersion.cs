using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class InteractiveVersion : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("gameId")]
    public uint GameId { get; private set; }

    [JsonProperty("version")]
    public string Version { get; private set; }

    [JsonProperty("versionOrder")]
    public uint VersionOrder { get; private set; }

    [JsonProperty("changelog")]
    public string Changelog { get; private set; }

    [JsonProperty("state")]
    public string State { get; private set; }

    [JsonProperty("installation")]
    public string Installation { get; private set; }

    [JsonProperty("download")]
    public string Download { get; private set; }

    [JsonProperty("controls")]
    public InteractiveControls Controls { get; private set; }

    [JsonProperty("controlVersion")]
    public string ControlVersion { get; private set; }
  }
}
