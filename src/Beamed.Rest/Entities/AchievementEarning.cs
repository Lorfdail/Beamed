using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class AchievementEarning : IEntity {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }
    
    [JsonProperty(PropertyName = "earned")]
    public bool Earned { get; private set; }
    
    [JsonProperty(PropertyName = "progress")]
    public double Progress { get; private set; }

    [JsonProperty(PropertyName = "achievement")]
    public string AchievementName { get; private set; }
    
    [JsonProperty(PropertyName = "user")]
    public uint UserId { get; private set; }
    
    [JsonProperty(PropertyName = "Achievement")]
    public Achievement Achievement { get; private set; }
  }
}
