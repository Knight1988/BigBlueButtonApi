using System;
using System.IO;
using System.Net;
using System.Text;
using BigBlueButtonApi.Responses;

namespace BigBlueButtonApi
{
    public class BigBlueButton
    {
        /// <summary>
        /// Create BigBlueButton instance
        /// </summary>
        /// <param name="url">The api url example http://test-install.blindsidenetworks.com/bigbluebutton/api </param>
        /// <param name="salt">Secret key</param>
        public BigBlueButton(string url, string salt)
        {
            Url = url.EndsWith("/") ? url : url + "/";
            Salt = salt;
        }

        /// <summary>
        /// Api url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Secret key
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        ///     Get the Api Version
        /// </summary>
        /// <returns></returns>
        public Response GetVersion()
        {
            return Response.Parse<Response>(HttpGet(Url));
        }

        /// <summary>
        /// Create a meeting room
        /// </summary>
        /// <param name="meetingId">The meetings Id</param>
        /// <param name="name">Name of the meeting</param>
        /// <param name="attendeePassword">attendee password</param>
        /// <param name="moderatorPassword">moderator password</param>
        /// <param name="record">allow recording</param>
        /// <param name="allowStartStopRecording">allow start/stop recording</param>
        /// <param name="autoStartRecording">start recording on start</param>
        /// <param name="voiceBridge">voice bridge</param>
        /// <param name="welcome">welcome message</param>
        /// <param name="logoutUrl">redirect url when logout</param>
        /// <returns></returns>
        public CreateResponse Create(string meetingId, string name, string attendeePassword, string moderatorPassword,
            bool record = true, bool allowStartStopRecording = true, bool autoStartRecording = false,
            int voiceBridge = 76894, string welcome = null, string logoutUrl = null)
        {
            var qb = new QueryStringBuilder
            {
                {"meetingID", meetingId},
                {"name", name},
                {"attendeePW", attendeePassword},
                {"moderatorPW", moderatorPassword},
                {"record", record.ToString()},
                {"allowStartStopRecording", allowStartStopRecording.ToString()},
                {"autoStartRecording", autoStartRecording.ToString()},
                {"voiceBridge", voiceBridge.ToString()},
                {"welcome", welcome},
                {"logoutURL", logoutUrl},
            };
            qb.Add("checksum", GenerateChecksum("create", qb.ToString()));
            return Response.Parse<CreateResponse>(HttpGet(Url + "create?" + qb));
        }

        /// <summary>
        /// Join the meeting, user role depend on the password
        /// </summary>
        /// <param name="meetingId">meeiting id</param>
        /// <param name="name">user's name</param>
        /// <param name="password">meeting password</param>
        /// <param name="redirect"></param>
        /// <returns></returns>
        public string Join(string meetingId, string name, string password, bool redirect = true)
        {
            var qb = new QueryStringBuilder
            {
                {"fullName", name},
                {"meetingID", meetingId},
                {"password", password},
                {"redirect", redirect.ToString().ToLower()}
            };
            qb.Add("checksum", GenerateChecksum("join", qb.ToString()));
            return Url + "join?" + qb;
        }

        /// <summary>
        /// Check if the meeting is running
        /// </summary>
        /// <param name="meetingId"></param>
        /// <returns></returns>
        public IsMeetingRunningResponse IsMeetingRunning(string meetingId)
        {
            var qb = new QueryStringBuilder
            {
                {"meetingID", meetingId}
            };
            qb.Add("checksum", GenerateChecksum("isMeetingRunning", qb.ToString()));
            return Response.Parse<IsMeetingRunningResponse>(HttpGet(Url + "isMeetingRunning?" + qb));
        }

        /// <summary>
        /// Get the meeting info
        /// </summary>
        /// <param name="meetingId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public MeetingInfoResponse GetMeetingInfo(string meetingId, string password)
        {
            var qb = new QueryStringBuilder
            {
                {"meetingID", meetingId},
                {"password", password},
            };
            qb.Add("checksum", GenerateChecksum("getMeetingInfo", qb.ToString()));
            return Response.Parse<MeetingInfoResponse>(HttpGet(Url + "getMeetingInfo?" + qb));
        }

        /// <summary>
        /// End the meeting
        /// </summary>
        /// <param name="meetingId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Response End(string meetingId, string password)
        {
            var qb = new QueryStringBuilder
            {
                {"meetingID", meetingId},
                {"password", password},
            };
            qb.Add("checksum", GenerateChecksum("end", qb.ToString()));
            return Response.Parse<Response>(HttpGet(Url + "end?" + qb));
        }

        /// <summary>
        /// Get meetings
        /// </summary>
        /// <param name="meetingId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public GetMeetingResponse GetMeetings()
        {
            var qb = new QueryStringBuilder();
            qb.Add("checksum", GenerateChecksum("getMeetings", qb.ToString()));
            return Response.Parse<GetMeetingResponse>(HttpGet(Url + "getMeetings?" + qb));
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

        private string GenerateChecksum(string apicallName, string parameters)
        {
            return SHA1.SHA1HashStringForUTF8String(apicallName + parameters + Salt);
        }
    }
}