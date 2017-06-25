using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Threading;

namespace Beamed.Rest.Net {

  struct RateLimitBucket {
    public uint Total;
    public uint Remaining;
    public DateTime ResetTime;
  }

  class RateLimitManager {
    private Dictionary<string, RateLimitBucket> RateLimits = new Dictionary<string, RateLimitBucket>();

    public uint FreeRequests(string key) {
      if(RateLimits.ContainsKey(key))
        return RateLimits[key].Remaining;
      return 1;
    }

    public int MsUntilRequest(string key) {
      if(RateLimits.ContainsKey(key))
        return (RateLimits[key].ResetTime - DateTime.UtcNow).Milliseconds;
      return 0;
    }
    
    public bool CanRequest(string key)
      => FreeRequests(key) > 0;

    public void UpdateLimit(HttpResponseHeaders headers, string key) {
      uint.TryParse(HttpUtil.getFirstHeaderValue(headers, "x-rate-limit"), out uint rateLimit);
      uint.TryParse(HttpUtil.getFirstHeaderValue(headers, "x-ratelimit-remaining"), out uint rateLimitRemaining);
      uint.TryParse(HttpUtil.getFirstHeaderValue(headers, "x-ratelimit-reset"), out uint rateLimitReset);

      RateLimitBucket bucket = new RateLimitBucket {
        Total = rateLimit,
        Remaining = rateLimitRemaining,
        ResetTime = DateTime.UtcNow.AddMilliseconds(rateLimitReset)
      };

      if(RateLimits.ContainsKey(key)) 
        RateLimits[key] = bucket;
      else
        RateLimits.Add(key, bucket);
    }

    public async Task<bool> WaitForLimit(string key, uint maxRateLimitWait) 
      => await WaitForLimit(key, maxRateLimitWait, CancellationToken.None);

    public async Task<bool> WaitForLimit(string key, uint maxRateLimitWait, CancellationToken token) {
      if(RateLimits.ContainsKey(key)) {
        int resetTime = MsUntilRequest(key);
        if(resetTime > maxRateLimitWait)
          return false;
        await Task.Delay(resetTime, token);
        return true;
      }
      return true;
    }
  }
}
