using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class AchievementEarning : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }
    
    [JsonProperty("earned")]
    public bool Earned { get; private set; }
    
    [JsonProperty("progress")]
    public double Progress { get; private set; }

    [JsonProperty("achievement")]
    public string AchievementName { get; private set; }
    
    [JsonProperty("user")]
    public uint UserId { get; private set; }
    
    [JsonProperty("Achievement")]
    public Achievement Achievement { get; private set; }
  }
}
