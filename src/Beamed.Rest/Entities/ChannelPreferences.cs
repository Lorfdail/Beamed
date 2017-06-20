using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class ChannelPreferences : Entity {
    [JsonProperty("sharetext")]
    public string ShareText { get; private set; }
    
    [JsonProperty("channel:links:allowed")]
    public bool? LinksAllowed { get; private set; }
    
    [JsonProperty("channel:links:clickable")]
    public bool? LinksClickable { get; private set; }
    
    [JsonProperty("channel:slowchat")]
    public double? SlowChat { get; private set; }
    
    [JsonProperty("channel:notify:subscribemessage")]
    public string NotifySubscribeMessage { get; private set; }
    
    [JsonProperty("channel:notify:subscribe")]
    public bool? NotifyOnSubscribe { get; private set; }
    
    [JsonProperty("channel:notify:followmessage")]
    public string NotifyFollowMessage { get; private set; }
    
    [JsonProperty("channel:notify:follow")]
    public bool? NotifyOnFollow { get; private set; }
    
    [JsonProperty("channel:notify:hostedBy")]
    public string HostedBy { get; private set; }
    
    [JsonProperty("channel:notify:hosting")]
    public bool? NotifyOnHosting { get; private set; }
    
    [JsonProperty("channel:partner:submail")]
    public string PartnerSubscriptionMail { get; private set; }
    
    [JsonProperty("channel:player:muteOwn")]
    public bool? PlayerMuteOwn { get; private set; }
    
    [JsonProperty("channel:tweet:enabled")]
    public bool? TweetEnabled { get; private set; }
    
    [JsonProperty("channel:tweet:body")]
    public string TweetBody { get; private set; }
    
    [JsonProperty("costream:allow")]
    public bool AllowCostream { get; private set; }
  }
}
