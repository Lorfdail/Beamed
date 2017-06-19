using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Beamed.Rest;
using Beamed.Rest.Net;

namespace Beamed.Core {
  public class MixerClient {
    private MixerRestClient _rest = new MixerRestClient(MixerConstants.API_BASE);

    public bool Authenticated { get; private set; } = false;
    public string Token { get; private set; }
  }
}
