using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Beamed.Core {
  public class MixerClient {
    public bool Authenticated { get; private set; } = false;
    public string Token { get; private set; }
  }
}
