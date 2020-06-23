using BigBlueButtonApi.Responses;
using System.Collections.Generic;

namespace BigBlueButtonApi
{
    public interface IBigBlueButton
    {
        string Salt { get; set; }
        string Url { get; set; }

        MeetingCreateResponse Create(string meetingId, string name, string attendeePassword,
            string moderatorPassword, bool record = true, bool allowStartStopRecording = true, bool autoStartRecording = false,
            int voiceBridge = 76894, string welcome = null
            , string logoutUrl = null,
            string meetingEndUrl = null,
            string recordingEndUrl = null);
        Response End(string meetingId, string password);
        MeetingInfoResponse GetMeetingInfo(string meetingId, string password);
        GetMeetingResponse GetMeetings();
        GetRecordingsResponse GetRecordings(string meetingId = null, string recordId = null);
        Response GetVersion();
        IsMeetingRunningResponse IsMeetingRunning(string meetingId);
        string Join(string meetingId, string name, string userId, string password, bool redirect = true);
        JwtTokenResult DecodeJwtToken(string jwtEncoded);
    }
}