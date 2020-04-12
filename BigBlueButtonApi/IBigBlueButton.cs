using BigBlueButtonApi.Responses;

namespace BigBlueButtonApi
{
    public interface IBigBlueButton
    {
        string Salt { get; set; }
        string Url { get; set; }

        CreateResponse Create(string meetingId, string name, string attendeePassword, string moderatorPassword, bool record = true, bool allowStartStopRecording = true, bool autoStartRecording = false, int voiceBridge = 76894, string welcome = null, string logoutUrl = null);
        Response End(string meetingId, string password);
        MeetingInfoResponse GetMeetingInfo(string meetingId, string password);
        GetMeetingResponse GetMeetings();
        GetRecordingsResponse GetRecordings(string meetingId = null);
        Response GetVersion();
        IsMeetingRunningResponse IsMeetingRunning(string meetingId);
        string Join(string meetingId, string name, string password, bool redirect = true);
    }
}