using System;
using System.IO;
using System.Net;
using System.Text;
using BigBlueButtonApi.Responses;

namespace BigBlueButtonApi
{
    public class BigBlueButton
    {
        public BigBlueButton(string url, string salt)
        {
            Url = url;
            Salt = salt;
        }

        public string Url { get; set; }

        public string Salt { get; set; }

        /// <summary>
        /// Get the Api Version
        /// </summary>
        /// <returns></returns>
        public Response GetVersion()
        {
            return Response.Parse<Response>(HttpGet(Url));
        }

        private static string HttpGet(string url)
        {
            using (var wb = new WebClient())
            {
                return wb.DownloadString(url);
            }
        }

        private static string HttpPost(string url, string postData)
        {
            var request = (HttpWebRequest) WebRequest.Create(url);

            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "text/xml";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse) request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream == null) throw new NullReferenceException("responseStream is null");
            var responseString = new StreamReader(responseStream).ReadToEnd();

            return responseString;
        }

        private string GenerateChecksum(string prefix, string str)
        {
            return SHA1.SHA1HashStringForUTF8String(prefix + str + Salt);
        }
    }
}