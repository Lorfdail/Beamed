using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Beamed.Rest.Net {
  struct RateLimitBucket {
    public string Name;
    public uint RequestCount;
    public TimeSpan TimeInterval;

    public RateLimitBucket(string name, uint requestCount, double secondsInterval)
      : this(name, requestCount, TimeSpan.FromSeconds(secondsInterval)) { }

    public RateLimitBucket(string name, uint requestCount, TimeSpan interval) {
      Name = name;
      RequestCount = requestCount;
      TimeInterval = interval;
    }
  }

  struct RateLimitTracker {
    public DateTime TimeBeginLimit;
    public uint RequestCount;
  }

  class RateLimitManager {
    public static readonly Dictionary<string, RateLimitBucket> RateLimits = new Dictionary<string, RateLimitBucket> {
      { "channel-follow", new RateLimitBucket("channel-follow", 100, 60) },
      { "channel-read", new RateLimitBucket("channel-read", 1000, 300) },
      { "channel-search", new RateLimitBucket("channel-search", 20, 5) },
      { "channel-write", new RateLimitBucket("channel-write", 250, 300) },
      { "chats", new RateLimitBucket("chats", 500, 60) },
      { "contact", new RateLimitBucket("contact", 3, 60) },
      { "global", new RateLimitBucket("global", 1000, 60) },
      { "ingest", new RateLimitBucket("ingest", 5, 60) },
      { "mail-subscribe", new RateLimitBucket("mail-subscribe", 3, 60) },
      { "notification-read", new RateLimitBucket("notification-read", 100, 60) },
      { "report", new RateLimitBucket("report", 10, 60) },
      { "upload", new RateLimitBucket("upload", 5, 600) },
      { "user-email", new RateLimitBucket("user-email", 2, 86400) },
      { "user-login", new RateLimitBucket("user-login", 50, 60) },
      { "user-login-failed", new RateLimitBucket("user-login-failed", 8, 900) },
      { "user-read", new RateLimitBucket("user-read", 500, 60) },
      { "user-register", new RateLimitBucket("user-register", 2, 60) },
      { "user-write", new RateLimitBucket("user-write", 100, 60) },
    };

    private Dictionary<string, RateLimitTracker> _requestTimeRecords = new Dictionary<string, RateLimitTracker>();

    public uint FreeRequests(string key) {
      RateLimitBucket bucket = GetRateLimitBucket(key);

      if(_requestTimeRecords.TryGetValue(bucket.Name, out RateLimitTracker tracker)) {
        // this tracker is outdated so we just get rid of it
        if((DateTime.Now - tracker.TimeBeginLimit) > bucket.TimeInterval) {
          _requestTimeRecords.Remove(bucket.Name);
          return bucket.RequestCount;
        }

        // the time limit was not reached yet so lets just use math!
        return bucket.RequestCount - tracker.RequestCount;
      }
      return bucket.RequestCount;
    }

    public bool CanRequest(string key)
      => FreeRequests(key) > 0;

    public int MsUntilRequest(string key) {
      RateLimitBucket bucket = GetRateLimitBucket(key);

      // we have atleast one free request so no need to wait at all
      // TODO: make this use a time check directly
      if(FreeRequests(key) > 0)
        return 0;

      // if we substract the time when the limit end from the current time we get the remaining time
      if(_requestTimeRecords.TryGetValue(bucket.Name, out RateLimitTracker tracker))
        return (tracker.TimeBeginLimit.Add(bucket.TimeInterval) - DateTime.Now).Milliseconds;

      // there is no tracker .. no tracker == no limits!
      return 0;
    }

    public async Task<bool> ReserveRequest(string key) {
      RateLimitBucket bucket = GetRateLimitBucket(key);

      if(_requestTimeRecords.TryGetValue(bucket.Name, out RateLimitTracker tracker)) {
        // we have atleast one free request just increase the count and continue we do not need to care about resetting it or anything
        if(bucket.RequestCount > tracker.RequestCount) {
          tracker.RequestCount++;
          return true;
        }

        // lets wait until the limit vanishes 
        // TODO: make this abort when we have something more than 1 minute or so since now it could happen that we wait 2 hours for a user mail
        await WaitForRateLimit(key).ConfigureAwait(false);
        tracker.RequestCount = 1;
        return true;
      }

      // we didnt track this one yet lets add it 
      _requestTimeRecords.Add(key, new RateLimitTracker { TimeBeginLimit = DateTime.Now, RequestCount = 1});
      return true;
    }

    public async Task WaitForRateLimit(string key)
      => await Task.Delay(MsUntilRequest(key)).ConfigureAwait(false);

    public RateLimitBucket GetRateLimitBucket(string key) {
      // if we cant grab the bucket make a nice exception <3
      if(!RateLimits.TryGetValue(key, out RateLimitBucket bucket))
        throw new KeyNotFoundException($"A Ratelimit with the key '{key}' does not exist");
      return bucket;
    }
  }
}
