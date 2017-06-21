using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class TeamMembership : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("teamId")]
    public uint TeamId { get; private set; }

    [JsonProperty("userId")]
    public uint UserId { get; private set; }

    [JsonProperty("accepted")]
    public bool Accepted { get; private set; }
  }
}
