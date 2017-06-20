using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class CostreamChannel : Entity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("userId")]
    public uint UserId { get; private set; }

    [JsonProperty("token")]
    public string Token { get; private set; }
  }

  public class Costream : Entity {
    [JsonProperty("channels")]
    public CostreamChannel[] Channels { get; private set; }

    [JsonProperty("startedAt")]
    public string StartedAt { get; private set; }

    [JsonProperty("capacity")]
    public uint Capacity { get; private set; }

    [JsonProperty("layout")]
    public CostreamLayout Layout { get; private set; }
  }
}
