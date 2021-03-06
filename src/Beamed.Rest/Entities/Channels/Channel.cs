using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Beamed.Rest.Net;
using Newtonsoft.Json;

namespace Beamed.Rest.Entities.Channels {
  public class Channel : TimeStamped {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("userId")]
    public uint UserId { get; private set; }

    [JsonProperty("token")]
    public string Token { get; private set; }

    [JsonProperty("online")]
    public bool Online { get; private set; }

    public bool Featured { get => FeatureLevel > 0; }

    [JsonProperty("featureLevel")]
    public int FeatureLevel { get; private set; }

    [JsonProperty("partenered")]
    public bool Partenered { get; private set; }

    [JsonProperty("transcodingProfileId")]
    public uint? TranscodingProfileId { get; private set; }

    [JsonProperty("suspended")]
    public bool Suspended { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("audience")]
    public string Audience { get; private set; }

    [JsonProperty("viewersTotal")]
    public uint ViewersTotal { get; private set; }

    [JsonProperty("viewersCurrent")]
    public uint ViewersCurrent { get; private set; }

    [JsonProperty("numFollowers")]
    public uint NumFollowers { get; private set; }

    [JsonProperty("description")]
    public string Description { get; private set; }

    [JsonProperty("typeId")]
    public uint? TypeId { get; private set; }

    [JsonProperty("interactive")]
    public bool Interactive { get; private set; }

    [JsonProperty("interactiveGameId")]
    public uint? InteractiveGameId { get; private set; }

    // documented as uint but saw having a negative value?
    [JsonProperty("ftl")]
    public int FTL { get; private set; }

    [JsonProperty("hasVod")]
    public bool HasVod { get; private set; }

    [JsonProperty("languageId")]
    public string LanguageId { get; private set; }

    [JsonProperty("coverId")]
    public uint? CoverId { get; private set; }

    [JsonProperty("thumbnailId")]
    public uint? ThumbnailId { get; private set; }

    [JsonProperty("vodsEnabled")]
    public bool VodsEnabled { get; private set; }

    [JsonProperty("costreamId")]
    public string CostreamId { get; private set; }

    public async Task<DetailChannel> GetDetailsAsync()
      => await ((MixerRestClient) Client).RequestEndpointAsync<DetailChannel>($"/channels/{Id}/details", HttpMethod.Get);

    public async Task<DetailChannel> GetDetailsAsync(CancellationToken token)
      => await ((MixerRestClient) Client).RequestEndpointAsync<DetailChannel>($"/channels/{Id}/details", HttpMethod.Get, token);
  }
}
