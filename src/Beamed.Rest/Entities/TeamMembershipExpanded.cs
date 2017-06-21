using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class TeamMembershipExpanded : TeamMembership {
    [JsonProperty("isPrimary")]
    public bool IsPrimary { get; private set; }

    [JsonProperty("owner")]
    public User Owner { get; private set; }

    [JsonProperty("teamMembership")]
    public TeamMembership TeamMembership { get; private set; }
  }
}
