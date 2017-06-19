using System;
using System.Collections.Generic;

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

    private Dictionary<string, DateTime> _requestTimeRecords = new Dictionary<string, DateTime>();

    
  }
}
