using Newtonsoft.Json;

namespace Beamed.Rest.Entities {
  public class Blueprint {
    [JsonProperty("state")]
    public string State { get; private set; }

    [JsonProperty("grid")]
    public string Grid { get; private set; }

    [JsonProperty("x")]
    public uint X { get; private set; }

    [JsonProperty("y")]
    public uint Y { get; private set; }

    [JsonProperty("width")]
    public uint Width { get; private set; }

    [JsonProperty("height")]
    public uint Height { get; private set; }
  }

  public class ScreenBlueprint {
    [JsonProperty("state")]
    public string State { get; private set; }
  }

  public class Joystick {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("blueprint")]
    public Blueprint[] Blueprint { get; private set; }

    [JsonProperty("analysis")]
    public InteractiveJoyStickAnalysis Analysis { get; private set; }
  }

  public class Screen {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("blueprint")]
    public ScreenBlueprint[] Blueprint { get; private set; }

    public InteractiveScreenAnalysis Analysis { get; private set; }
  }

  public class Tactile {
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("blueprint")]
    public Blueprint[] Blueprint { get; private set; }

    [JsonProperty("key")]
    public uint Key { get; private set; }

    [JsonProperty("text")]
    public string Text { get; private set; }

    [JsonProperty("cost.press.cost")]
    public uint Cost { get; private set; }

    [JsonProperty("cooldown.press")]
    public int? Cooldown { get; private set; }

    [JsonProperty("analysis")]
    public InteractiveTactileAnalysis Analysis { get; private set; }
  }

  public class InteractiveControls : Entity {
    [JsonProperty("reportInterval")]
    public uint ReportInterval { get; private set; }

    [JsonProperty("joysticks")]
    public Joystick[] Joysticks { get; private set; }

    [JsonProperty("screens")]
    public Screen[] Screens { get; private set; }

    [JsonProperty("tactiles")]
    public Tactile[] Tactiles { get; private set; }
  }
}
