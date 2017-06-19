using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public struct RestChannel {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "userId")]
    public uint UserId { get; private set; }

    [JsonProperty(PropertyName = "token")]
    public string Token { get; private set; }

    [JsonProperty(PropertyName = "online")]
    public bool Online { get; private set; }

    public bool Featured { get => FeatureLevel > 0; }

    [JsonProperty(PropertyName = "featureLevel")]
    public int FeatureLevel { get; private set; }

    [JsonProperty(PropertyName = "partenered")]
    public bool Partenered { get; private set; }

    [JsonProperty(PropertyName = "transcodingProfileId")]
    public uint? TranscodingProfileId { get; private set; }

    [JsonProperty(PropertyName = "suspended")]
    public bool Suspended { get; private set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; private set; }

    [JsonProperty(PropertyName = "audience")]
    public string Audience { get; private set; }

    [JsonProperty(PropertyName = "viewersTotal")]
    public uint ViewersTotal { get; private set; }

    [JsonProperty(PropertyName = "viewersCurrent")]
    public uint ViewersCurrent { get; private set; }

    [JsonProperty(PropertyName = "numFollowers")]
    public uint NumFollowers { get; private set; }

    [JsonProperty(PropertyName = "description")]
    public string Description { get; private set; }

    [JsonProperty(PropertyName = "typeId")]
    public uint? TypeId { get; private set; }

    [JsonProperty(PropertyName = "interactive")]
    public bool Interactive { get; private set; }

    [JsonProperty(PropertyName = "interactiveGameId")]
    public uint? InteractiveGameId { get; private set; }

    // documented as uint but saw having a negative value?
    [JsonProperty(PropertyName = "ftl")]
    public int FTL { get; private set; }

    [JsonProperty(PropertyName = "hasVod")]
    public bool HasVod { get; private set; }

    [JsonProperty(PropertyName = "languageId")]
    public string LanguageId { get; private set; }

    [JsonProperty(PropertyName = "coverId")]
    public uint? CoverId { get; private set; }

    [JsonProperty(PropertyName = "thumbnailId")]
    public uint? ThumbnailId { get; private set; }

    [JsonProperty(PropertyName = "vodsEnabled")]
    public bool VodsEnabled { get; private set; }

    [JsonProperty(PropertyName = "costreamId")]
    public string CostreamId { get; private set; }

    [JsonProperty(PropertyName = "thumbnail")]
    public RestResource Thumbnail { get; private set; }

    [JsonProperty(PropertyName = "user")]
    public RestUser User { get; private set; }
    
    [JsonProperty(PropertyName = "type")]
    public RestGameType Type { get; private set; }
  }
}
