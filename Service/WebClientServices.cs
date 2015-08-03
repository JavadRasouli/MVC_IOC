using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service
{
    public class WebClientServices : IWebClientServices
    {
        public string FetchUrl(string url)
        {
            using (var client = new WebClient { Encoding = Encoding.UTF8 })
            {
                return client.DownloadString(url);
            }
        }

        public string GetWebPageTitle(string url)
        {
            var html = FetchUrl(url);
            var match = new Regex(@"(?s)<title>(.+?)</title>", RegexOptions.IgnoreCase).Match(html);
            return match.Groups[1].Value.Trim();
        }
    }
}
