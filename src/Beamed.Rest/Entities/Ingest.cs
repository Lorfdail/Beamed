using System.Collections.Generic;
using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Ingest : Entity {
    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("host")]
    public string Host { get; private set; }

    [JsonProperty("pingTest")]
    public string PingTest { get; private set; }

    [JsonProperty("protocols")]
    public KeyValuePair<string, string>[] Protocols { get; private set; }
  }
}
