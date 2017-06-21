using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Beamed.Core {
  public class MixerClient : IDisposable {
    public bool Authenticated { get; private set; } = false;
    public string Token { get; private set; }

    public void Dispose()
    { 
        Dispose(true);
        GC.SuppressFinalize(this);           
    }

    protected virtual void Dispose(bool disposing) { }
  }
}
