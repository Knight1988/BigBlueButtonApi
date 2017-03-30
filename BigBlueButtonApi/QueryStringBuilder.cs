using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BigBlueButtonApi
{
    public class QueryStringBuilder : Dictionary<string, string>
    {
        public override string ToString()
        {
            var array = this.Where(p => p.Value != null).Select(p =>
            {
                var key = HttpUtility.UrlEncode(p.Key);
                var value = HttpUtility.UrlEncode(p.Value);

                return key + "=" + value;
            }).ToArray();
            return string.Join("&", array);
        }
    }
}
