using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public abstract class IConfettiShape : IEntity {
    public string Shape;
    
    public T As<T>() where T: IConfettiShape {
      return (T)this;
    }
  }

  public class ConfettiColor {
    [JsonProperty("probability")]
    public double probability { get; private set; }

    [JsonProperty("r")]
    public string Red { get; private set; }

    [JsonProperty("g")]
    public string Green { get; private set; }

    [JsonProperty("b")]
    public string Blue { get; private set; }
  }

  public class ConfettiParticle {
    [JsonProperty("probability")]
    public double Probability { get; private set; }

    [JsonProperty("velocity")]
    public string Velocity { get; private set; }

    [JsonProperty("zdepth")]
    public string ZDepth { get; private set; }

    [JsonProperty("wiggleMagnitude")]
    public string WiggleMagnitude { get; private set; }

    [JsonProperty("wigglePeriod")]
    public string WigglePeriod { get; private set; }

    [JsonProperty("lifetime")]
    public string Lifetime { get; private set; }

    [JsonProperty("fader")]
    public string Fader { get; private set; }

    [JsonProperty("draw")]
    public IConfettiShape Shape { get; private set; }
  }

  public class ConfettiSettings {
    [JsonProperty("count")]
    public string Count { get; private set; }

    [JsonProperty("particles")]
    public ConfettiParticle[] Particles { get; private set; }
  }

  public class Confetti : IEntity {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("channelId")]
    public uint ChannelId { get; private set; }

    [JsonProperty("settings")]
    public ConfettiSettings Settings { get; private set; }
  }
}
