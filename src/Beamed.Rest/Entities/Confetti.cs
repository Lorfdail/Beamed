using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public abstract class IConfettiShape : IEntity {
    public string Shape;
    
    public T As<T>() where T: IConfettiShape {
      return (T)this;
    }
  }

  public class ConfettiColor {
    [JsonProperty(PropertyName = "probability")]
    public double probability { get; private set; }

    [JsonProperty(PropertyName = "r")]
    public string Red { get; private set; }

    [JsonProperty(PropertyName = "g")]
    public string Green { get; private set; }

    [JsonProperty(PropertyName = "b")]
    public string Blue { get; private set; }
  }

  public class ConfettiParticle {
    [JsonProperty(PropertyName = "probability")]
    public double Probability { get; private set; }

    [JsonProperty(PropertyName = "velocity")]
    public string Velocity { get; private set; }

    [JsonProperty(PropertyName = "zdepth")]
    public string ZDepth { get; private set; }

    [JsonProperty(PropertyName = "wiggleMagnitude")]
    public string WiggleMagnitude { get; private set; }

    [JsonProperty(PropertyName = "wigglePeriod")]
    public string WigglePeriod { get; private set; }

    [JsonProperty(PropertyName = "lifetime")]
    public string Lifetime { get; private set; }

    [JsonProperty(PropertyName = "fader")]
    public string Fader { get; private set; }

    [JsonProperty(PropertyName = "draw")]
    public IConfettiShape Shape { get; private set; }
  }

  public class ConfettiSettings {
    [JsonProperty(PropertyName = "count")]
    public string Count { get; private set; }

    [JsonProperty(PropertyName = "particles")]
    public ConfettiParticle[] Particles { get; private set; }
  }

  public class Confetti : IEntity {
    [JsonProperty(PropertyName = "id")]
    public uint Id { get; private set; }

    [JsonProperty(PropertyName = "channelId")]
    public uint ChannelId { get; private set; }

    [JsonProperty(PropertyName = "settings")]
    public ConfettiSettings Settings { get; private set; }
  }
}
