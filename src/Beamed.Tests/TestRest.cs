using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Xunit;
using Newtonsoft.Json;
using Beamed.Core;
using Beamed.Rest;
using Beamed.Rest.Entities;

namespace Beamed.Tests {
  public class TestRest {
    MixerClient client = new MixerClient();

    [Fact]
    public async void Channel() {
      var client = new HttpClient {
        BaseAddress = new Uri("https://mixer.com/api/v1/")
      };

      var response = await client.GetAsync("channels");
      Assert.Equal(response.StatusCode, HttpStatusCode.OK);

      var channels = JsonConvert.DeserializeObject<List<ChannelAdvanced>>(await response.Content.ReadAsStringAsync());
      Assert.Equal(channels.Count, 50);

      // check if every Channel has an User attached to it
      Assert.All(channels, (channel) => Assert.NotNull(channel.User));
    }
  }
}
