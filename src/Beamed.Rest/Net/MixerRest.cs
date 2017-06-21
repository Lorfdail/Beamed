using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;
using Beamed.Core;

namespace Beamed.Rest.Net {
  public class MixerRestClient : MixerClient {
    private HttpClient _client;
    public Uri ResourceUri { get; private set; }
    private RateLimitManager rateLimitManager { get; set; }
    public uint MaxRateLimitWait { get; set; }

    public MixerRestClient(Uri resource) {
      _client = new HttpClient(); // new HttpClient(new LoggingHandler(new HttpClientHandler()));
      rateLimitManager = new RateLimitManager();
      ResourceUri = new Uri(MixerConstants.API_BASE);
      MaxRateLimitWait = 60000;
    }
    
    public async Task<T> RequestEndpointAsync<T> (string endpoint, HttpMethod method, string bucketKey = null) where T: Beamed.Rest.Entity
      => await RequestEndpointAsync<T>(new Uri(endpoint), method, bucketKey);

    public async Task<T> RequestEndpointAsync<T> (Uri endpoint, HttpMethod method, string bucketKey = null) where T: Beamed.Rest.Entity {
      if(!base.Authenticated)
        return null;
      _client.DefaultRequestHeaders.Clear();
      _client.DefaultRequestHeaders.Add("Authorization", base.Token);

      HttpRequestMessage request = new HttpRequestMessage(method, endpoint);
      HttpResponseMessage response = null;

      try {
        if(bucketKey != null) {
          if(!await rateLimitManager.WaitForLimit(bucketKey, MaxRateLimitWait))
            return default(T);
        }

        response = await _client.SendAsync(request); 
        if(bucketKey != null)
          rateLimitManager.UpdateLimit(response.Headers, bucketKey);
        response.EnsureSuccessStatusCode();

        if (response != null)
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());    
      }
      finally {
          response?.Dispose();
          request?.Dispose();
      }

      return default(T);
    }
  }
}
