using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ChannelPreferences : IEntity {
    [JsonProperty(PropertyName = "sharetext")]
    public string ShareText { get; private set; }
    
    [JsonProperty(PropertyName = "channel:links:allowed")]
    public bool? LinksAllowed { get; private set; }
    
    [JsonProperty(PropertyName = "channel:links:clickable")]
    public bool? LinksClickable { get; private set; }
    
    [JsonProperty(PropertyName = "channel:slowchat")]
    public double? SlowChat { get; private set; }
    
    [JsonProperty(PropertyName = "channel:notify:subscribemessage")]
    public string NotifySubscribeMessage { get; private set; }
    
    [JsonProperty(PropertyName = "channel:notify:subscribe")]
    public bool? NotifyOnSubscribe { get; private set; }
    
    [JsonProperty(PropertyName = "channel:notify:followmessage")]
    public string NotifyFollowMessage { get; private set; }
    
    [JsonProperty(PropertyName = "channel:notify:follow")]
    public bool? NotifyOnFollow { get; private set; }
    
    [JsonProperty(PropertyName = "channel:notify:hostedBy")]
    public string HostedBy { get; private set; }
    
    [JsonProperty(PropertyName = "channel:notify:hosting")]
    public bool? NotifyOnHosting { get; private set; }
    
    [JsonProperty(PropertyName = "channel:partner:submail")]
    public string PartnerSubscriptionMail { get; private set; }
    
    [JsonProperty(PropertyName = "channel:player:muteOwn")]
    public bool? PlayerMuteOwn { get; private set; }
    
    [JsonProperty(PropertyName = "channel:tweet:enabled")]
    public bool? TweetEnabled { get; private set; }
    
    [JsonProperty(PropertyName = "channel:tweet:body")]
    public string TweetBody { get; private set; }
    
    [JsonProperty(PropertyName = "costream:allow")]
    public bool AllowCostream { get; private set; }
  }
}
