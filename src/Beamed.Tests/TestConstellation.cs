using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;
using Newtonsoft.Json.Linq;
using Beamed.Constellation;

namespace Beamed.Tests {
  public class TestConstellation {
    MixerConstellationClient client = new MixerConstellationClient();

    [Fact]
    public async void SessionInitialization() {
      client.OnHello += (JObject data) => {
        Assert.Equal(client.Authenticated, false);

        client.Dispose();
      };

      await client.ConnectAsync();
      await client.WSLoop();
    }
  }
}
