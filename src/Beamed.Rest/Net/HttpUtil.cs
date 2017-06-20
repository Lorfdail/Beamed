using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;

namespace Beamed.Rest.Net {
  public class HttpUtil {
    public static string getFirstHeaderValue(HttpResponseHeaders header, string key) {
      if(header.TryGetValues(key, out IEnumerable<string> values))
        return values.FirstOrDefault();
      return null;
    }
  }
}
