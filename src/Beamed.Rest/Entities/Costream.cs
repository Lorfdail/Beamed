using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class CostreamChannel : Entity {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "userId")]
    public uint UserId { get; private set; }

    [JsonProperty(PropertyName = "token")]
    public string Token { get; private set; }
  }

  public class Costream : Entity {
    [JsonProperty(PropertyName = "channels")]
    public CostreamChannel[] Channels { get; private set; }

    [JsonProperty(PropertyName = "startedAt")]
    public string StartedAt { get; private set; }

    [JsonProperty(PropertyName = "capacity")]
    public uint Capacity { get; private set; }

    [JsonProperty(PropertyName = "layout")]
    public CostreamLayout Layout { get; private set; }
  }
}
