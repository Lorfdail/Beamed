using System;
using System.Net.Http;

namespace Beamed.Rest.Net {
  public class MixerRestClient {
    private HttpClient _client = new HttpClient();
    public Uri ResourceUri { get; private set; }

    public MixerRestClient(string resource)
      : this(new Uri(resource)) { }

    public MixerRestClient(Uri resource) {
      ResourceUri = resource;
    }
  }
}
