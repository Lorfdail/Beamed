using System;
using Newtonsoft.Json;
using Xunit;
using Beamed.Rest.Entities;

namespace Beamed.Tests {
  public class TestRestJson {
    [Fact]
    public void TactileSubprop() {
      var a = JsonConvert.DeserializeObject<InteractiveControls>(@"
        {
          tactiles: [
            {
              cost: {
                press: { cost: 10 }
              },
              cooldown: { press: 15 }
            }
          ]
        }
      ");

      Assert.Equal(a.Tactiles[0].Cooldown.Press, 15);
      Assert.Equal<uint>(a.Tactiles[0].Cost.Press.Cost, 10);
    }
  }
}
