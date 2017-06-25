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
using System.Text;
using Beamed.Rest.Entities.Channels;

namespace Beamed.Rest.Net {

  public enum Scope {
    All,
    Names
  }

  public class MixerRestClient : MixerClient {
    private HttpClient _client;
    bool disposed = false;
    public Uri ResourceUri { get; protected set; }
    public uint MaxRateLimitWait { get; set; }
    private RateLimitManager _rateLimitManager { get; set; }    

    public MixerRestClient() {
      ResourceUri = new Uri(MixerConstants.API_BASE);
      _client = new HttpClient(); // new HttpClient(new LoggingHandler(new HttpClientHandler()));
      _client.BaseAddress = ResourceUri;
      _rateLimitManager = new RateLimitManager();
      MaxRateLimitWait = 60000;
    }

    public async Task<T> RequestEndpointAsync<T> (string endpoint, HttpMethod method, string bucketKey = null) 
      => await RequestEndpointAsync<T>(new Uri(endpoint), method, CancellationToken.None, bucketKey);

    public async Task<T> RequestEndpointAsync<T> (string endpoint, HttpMethod method, CancellationToken token, string bucketKey = null) 
    => await RequestEndpointAsync<T>(new Uri(endpoint), method, token, bucketKey);

    public async Task<T> RequestEndpointAsync<T> (Uri endpoint, HttpMethod method, string bucketKey = null) 
      => await RequestEndpointAsync<T>(endpoint, method, CancellationToken.None, bucketKey);

    public async Task<T> RequestEndpointAsync<T> (Uri endpoint, HttpMethod method, CancellationToken token, string bucketKey = null) {
      if(!base.Authenticated)
        throw new AuthenticationException("The Client is not authenticated");
      _client.DefaultRequestHeaders.Clear();
      _client.DefaultRequestHeaders.Add("Authorization", base.Token);

      HttpRequestMessage request = new HttpRequestMessage(method, endpoint);
      HttpResponseMessage response = null;

      try {
        if(bucketKey != null) {
          if(!await _rateLimitManager.WaitForLimit(bucketKey, MaxRateLimitWait, token).ConfigureAwait(false))
            return default(T);
        }

        response = await _client.SendAsync(request, token).ConfigureAwait(false); 
        if(bucketKey != null)
          _rateLimitManager.UpdateLimit(response.Headers, bucketKey);
        response.EnsureSuccessStatusCode();

        if (response != null) {
          T result = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false)); 
          if(typeof(IEnumerable<>).IsInstanceOfType(result)) {
            foreach(Entity entity in (IEnumerable<Entity>) result)
              entity.Client = this;
          }
          else
            (result as Entity).Client = this;
          return result;
        }
      }
      finally {
          response?.Dispose();
          request?.Dispose();
      }

      return default(T);
    }
  
    public async Task<T> SendToEndpointAsync<T> (string endpoint, HttpMethod method, object content = null, string bucketKey = null) 
      => await SendToEndpointAsync<T>(new Uri(endpoint), method, CancellationToken.None, content, bucketKey);  

    public async Task<T> SendToEndpointAsync<T> (string endpoint, HttpMethod method, CancellationToken token, object content = null, string bucketKey = null) 
      => await SendToEndpointAsync<T>(new Uri(endpoint), method, token, content, bucketKey);

    public async Task<T> SendToEndpointAsync<T> (Uri endpoint, HttpMethod method, object content = null, string bucketKey = null) 
      => await SendToEndpointAsync<T>(endpoint, method, CancellationToken.None, content, bucketKey);
 
    public async Task<T> SendToEndpointAsync<T> (Uri endpoint, HttpMethod method, CancellationToken token, object content = null, string bucketKey = null) {
      if(!base.Authenticated)
        throw new AuthenticationException("The Client is not authenticated");
      _client.DefaultRequestHeaders.Clear();
      _client.DefaultRequestHeaders.Add("Authorization", base.Token);

      HttpRequestMessage request = new HttpRequestMessage(method, endpoint);
      if(content != null) {
        request.Content = new StringContent(JsonConvert.SerializeObject(content));
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
      }
      HttpResponseMessage response = null;

      try {
        if(bucketKey != null) {
          if(!await _rateLimitManager.WaitForLimit(bucketKey, MaxRateLimitWait, token).ConfigureAwait(false))
            return default(T);
        }

        response = await _client.SendAsync(request, token).ConfigureAwait(false); 
        if(bucketKey != null)
          _rateLimitManager.UpdateLimit(response.Headers, bucketKey);
        response.EnsureSuccessStatusCode();

        if (response != null) {
          T result = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false)); 
          if(typeof(IEnumerable<>).IsInstanceOfType(result)) {
            foreach(Entity entity in (IEnumerable<Entity>) result)
              entity.Client = this;
          }
          else
            (result as Entity).Client = this;
          return result;
        } 
      }
      finally {
          response?.Dispose();
          request?.Dispose();
      }

      return default(T);
    }
    
    public async Task SendToEndpointAsync (string endpoint, HttpMethod method, object content = null, string bucketKey = null) 
      => await SendToEndpointAsync(new Uri(endpoint), method, CancellationToken.None, content, bucketKey);

    public async Task SendToEndpointAsync (string endpoint, HttpMethod method, CancellationToken token, object content = null, string bucketKey = null) 
      => await SendToEndpointAsync(new Uri(endpoint), method, token, content, bucketKey);

    public async Task SendToEndpointAsync (Uri endpoint, HttpMethod method, object content = null, string bucketKey = null) 
      => await SendToEndpointAsync(endpoint, method, CancellationToken.None, content, bucketKey);

    public async Task SendToEndpointAsync (Uri endpoint, HttpMethod method, CancellationToken token, object content = null, string bucketKey = null) {
      if(!base.Authenticated)
        throw new AuthenticationException("The Client is not authenticated");
      _client.DefaultRequestHeaders.Clear();
      _client.DefaultRequestHeaders.Add("Authorization", base.Token);

      HttpRequestMessage request = new HttpRequestMessage(method, endpoint); 
      if(content != null) {
        request.Content = new StringContent(JsonConvert.SerializeObject(content));
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
      }
      HttpResponseMessage response = null;

      try {
        if(bucketKey != null) {
          if(!await _rateLimitManager.WaitForLimit(bucketKey, MaxRateLimitWait, token).ConfigureAwait(false))
            return;
        }

        response = await _client.SendAsync(request, token).ConfigureAwait(false); 
        if(bucketKey != null)
          _rateLimitManager.UpdateLimit(response.Headers, bucketKey);
        response.EnsureSuccessStatusCode();
      }
      finally {
          response?.Dispose();
          request?.Dispose();
      }

      return;
    }

    #region achievements

    public async Task<IReadOnlyCollection<Achievement>> GetAllAchievmentsAsync(CancellationToken token)
      => (await RequestEndpointAsync<IReadOnlyCollection<Achievement>>("/achievements", HttpMethod.Get, token).ConfigureAwait(false));

    public async Task<IReadOnlyCollection<Achievement>> GetAllAchievmentsAsync()
      => (await RequestEndpointAsync<IReadOnlyCollection<Achievement>>("/achievements", HttpMethod.Get).ConfigureAwait(false));

    #endregion

    #region announcements

    public async Task CreateAnnouncementAsync(Announcement announcement, CancellationToken token)
      => await SendToEndpointAsync("/announcements", HttpMethod.Post, token, announcement).ConfigureAwait(false);

    public async Task CreateAnnouncementAsync(Announcement announcement)
      => await SendToEndpointAsync("/announcements", HttpMethod.Post, announcement).ConfigureAwait(false);

    #endregion

    #region frontendversions

    public async Task<IReadOnlyCollection<FrontendVersion>> GetUserFrontendVersionsAsync(double userid)
      => (await RequestEndpointAsync<IReadOnlyCollection<FrontendVersion>>($"/frontendVersions?query={userid}", HttpMethod.Get).ConfigureAwait(false));

    #endregion

    #region ingests

    public async Task<IReadOnlyCollection<Ingest>> GetAllIngestsAsync()
      => (await RequestEndpointAsync<IReadOnlyCollection<Ingest>>("/ingests", HttpMethod.Get).ConfigureAwait(false));
        
    public async Task<IReadOnlyCollection<Ingest>> GetBestIngestsAsync()
      => (await RequestEndpointAsync<IReadOnlyCollection<Ingest>>("/ingests/best", HttpMethod.Get, "ingests").ConfigureAwait(false));
        
    #endregion

    #region transcodes
        
    public async Task<IReadOnlyCollection<ExpandedTranscodingProfile>> GetAllTranscodingsAsync()
      => (await RequestEndpointAsync<IReadOnlyCollection<ExpandedTranscodingProfile>>("/transcodes", HttpMethod.Get).ConfigureAwait(false));

    #endregion

    #region channels

    public async Task<IReadOnlyCollection<SearchChannel>> GetChannelsAsync(string searchQuery = null, bool orderByToken = false, ISearchBuilder builder = null, int limit = 50, Scope scope = Scope.All)
      => await GetChannelsAsync(CancellationToken.None, searchQuery, orderByToken, builder, limit, scope);

    public async Task<IReadOnlyCollection<SearchChannel>> GetChannelsAsync(CancellationToken token, string searchQuery = null, bool orderByToken = false, ISearchBuilder builder = null, int limit = 50, Scope scope = Scope.All) {
      StringBuilder query = new StringBuilder("/channels?noCount=true&search=");
      if(orderByToken)
        query.Append("true");
      else
        query.Append("false");
      if(limit < 50) {
        query.Append("&limit=");
        if(limit > 0)
          query.Append(limit);
        else
          query.Append(1);
      }
      query.Append("&q=");
      query.Append(searchQuery ?? "");
      query.Append("&scope=");
      if(scope == Scope.All)
        query.Append("all");
      else
        query.Append("names");
      query.Append(builder.BuildQuery());

      return await RequestEndpointAsync<IReadOnlyCollection<SearchChannel>>(query.ToString(), HttpMethod.Get, "channel-search");
    }

    public async Task<ExpandedChannel> GetChannelAsync(uint id)
      => await RequestEndpointAsync<ExpandedChannel>("/channels/" + id, HttpMethod.Get, "channel-read").ConfigureAwait(false);

    public async Task<ExpandedChannel> GetChannelAsync(string token)
      => await RequestEndpointAsync<ExpandedChannel>("/channels/" + token, HttpMethod.Get, "channel-read").ConfigureAwait(false);

    #endregion

    protected override void Dispose(bool disposing) {
      if (disposed)
          return; 

      if (disposing)
          _client.Dispose();

      disposed = true;
      base.Dispose(disposing);
    }
  }
}
