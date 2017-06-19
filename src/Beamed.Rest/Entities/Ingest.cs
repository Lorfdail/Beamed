using System.Collections.Generic;
using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Ingest : IEntity {
    [JsonProperty(PropertyName = "name")]
    public string Name { get; private set; }

    [JsonProperty(PropertyName = "host")]
    public string Host { get; private set; }

    [JsonProperty(PropertyName = "pingTest")]
    public string PingTest { get; private set; }

    [JsonProperty(PropertyName = "protocols")]
    public KeyValuePair<string, string>[] Protocols { get; private set; }
  }
}
