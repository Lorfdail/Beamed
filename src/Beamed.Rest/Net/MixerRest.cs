using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;
using Beamed.Core;
using System.Collections.Generic;
using Beamed.Rest.Entities;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Authentication;

namespace Beamed.Rest.Net {
  public class MixerRestClient : MixerClient {
    private HttpClient _client;
    bool disposed = false;
    public Uri ResourceUri { get; private set; }
    private RateLimitManager rateLimitManager { get; set; }
    public uint MaxRateLimitWait { get; set; }

    public MixerRestClient() {
      rateLimitManager = new RateLimitManager();
      ResourceUri = new Uri(MixerConstants.API_BASE);
      _client = new HttpClient(); // new HttpClient(new LoggingHandler(new HttpClientHandler()));
      _client.BaseAddress = ResourceUri;
      MaxRateLimitWait = 60000;
    }

    public async Task<T> RequestEndpointAsync<T> (string endpoint, HttpMethod method, string bucketKey = null) 
      => await RequestEndpointAsync<T>(new Uri(endpoint), method, bucketKey);

    public async Task<T> RequestEndpointAsync<T> (Uri endpoint, HttpMethod method, string bucketKey = null) {
      if(!base.Authenticated)
        throw new AuthenticationException("The Client is not authenticated");
      _client.DefaultRequestHeaders.Clear();
      _client.DefaultRequestHeaders.Add("Authorization", base.Token);

      HttpRequestMessage request = new HttpRequestMessage(method, endpoint);
      HttpResponseMessage response = null;

      try {
        if(bucketKey != null) {
          if(!await rateLimitManager.WaitForLimit(bucketKey, MaxRateLimitWait).ConfigureAwait(false))
            return default(T);
        }

        response = await _client.SendAsync(request).ConfigureAwait(false); 
        if(bucketKey != null)
          rateLimitManager.UpdateLimit(response.Headers, bucketKey);
        response.EnsureSuccessStatusCode();

        if (response != null)
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));    
      }
      finally {
          response?.Dispose();
          request?.Dispose();
      }

      return default(T);
    }
    
    public async Task<T> SendToEndpointAsync<T> (string endpoint, HttpMethod method, object content, string bucketKey = null) 
      => await SendToEndpointAsync<T>(new Uri(endpoint), method, bucketKey);

    public async Task<T> SendToEndpointAsync<T> (Uri endpoint, HttpMethod method, object content, string bucketKey = null) {
      if(!base.Authenticated)
        throw new AuthenticationException("The Client is not authenticated");
      _client.DefaultRequestHeaders.Clear();
      _client.DefaultRequestHeaders.Add("Authorization", base.Token);

      HttpRequestMessage request = new HttpRequestMessage(method, endpoint);
      request.Content = new StringContent(JsonConvert.SerializeObject(content));
      request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
      HttpResponseMessage response = null;

      try {
        if(bucketKey != null) {
          if(!await rateLimitManager.WaitForLimit(bucketKey, MaxRateLimitWait).ConfigureAwait(false))
            return default(T);
        }

        response = await _client.SendAsync(request).ConfigureAwait(false); 
        if(bucketKey != null)
          rateLimitManager.UpdateLimit(response.Headers, bucketKey);
        response.EnsureSuccessStatusCode();

        if (response != null)
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));    
      }
      finally {
          response?.Dispose();
          request?.Dispose();
      }

      return default(T);
    }
    
    public async Task SendToEndpointAsync (string endpoint, HttpMethod method, object content, string bucketKey = null) 
      => await SendToEndpointAsync(new Uri(endpoint), method, bucketKey);

    public async Task SendToEndpointAsync (Uri endpoint, HttpMethod method, object content, string bucketKey = null) {
      if(!base.Authenticated)
        throw new AuthenticationException("The Client is not authenticated");
      _client.DefaultRequestHeaders.Clear();
      _client.DefaultRequestHeaders.Add("Authorization", base.Token);

      HttpRequestMessage request = new HttpRequestMessage(method, endpoint);
      request.Content = new StringContent(JsonConvert.SerializeObject(content));
      request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
      HttpResponseMessage response = null;

      try {
        if(bucketKey != null) {
          if(!await rateLimitManager.WaitForLimit(bucketKey, MaxRateLimitWait).ConfigureAwait(false))
            return;
        }

        response = await _client.SendAsync(request).ConfigureAwait(false); 
        if(bucketKey != null)
          rateLimitManager.UpdateLimit(response.Headers, bucketKey);
        response.EnsureSuccessStatusCode();
      }
      finally {
          response?.Dispose();
          request?.Dispose();
      }

      return;
    }

    #region achievements
        
    public async Task<IReadOnlyCollection<Achievement>> GetAllAchievmentsAsync()
      => (await RequestEndpointAsync<List<Achievement>>("/achievements", HttpMethod.Get).ConfigureAwait(false)).AsReadOnly();

    #endregion

    #region announcements
        
    public async Task CreateAnnouncementAsync(Announcement announcement)
      => await SendToEndpointAsync("/announcements", HttpMethod.Post, announcement).ConfigureAwait(false);

    #endregion

    #region frontendversions

    public async Task<IReadOnlyCollection<FrontendVersion>> GetUserFrontendVersionsAsync(double userid)
      => (await RequestEndpointAsync<List<FrontendVersion>>($"/frontendVersions?query={userid}", HttpMethod.Get).ConfigureAwait(false)).AsReadOnly();

    #endregion

    #region ingests

    public async Task<IReadOnlyCollection<Ingest>> GetAllIngestsAsync()
      => (await RequestEndpointAsync<List<Ingest>>("/ingests", HttpMethod.Get).ConfigureAwait(false)).AsReadOnly();
        
    public async Task<IReadOnlyCollection<Ingest>> GetBestIngestsAsync()
      => (await RequestEndpointAsync<List<Ingest>>("/ingests/best", HttpMethod.Get, "ingests").ConfigureAwait(false)).AsReadOnly();
        
    #endregion

    #region transcodes
        
    public async Task<IReadOnlyCollection<ExpandedTranscodingProfile>> GetAllTranscodings()
      => (await RequestEndpointAsync<List<ExpandedTranscodingProfile>>("/transcodes", HttpMethod.Get).ConfigureAwait(false)).AsReadOnly();

    #endregion

    protected override void Dispose(bool disposing)
    {
      if (disposed)
          return; 

      if (disposing) {
          _client.Dispose();
      }

      disposed = true;
      base.Dispose(disposing);
    }
  }
}
