# BigBlueButtonApi
BigBlueButton API for .NET

Create the BigBlueButton object
 
# Get Version
Response GetVersion();
# Create a new meeting
CreateResponse Create(string meetingId, string name, string attendeePassword, string moderatorPassword, bool record = true, bool allowStartStopRecording = true, bool autoStartRecording = false, int voiceBridge = 76894, string welcome = null, string logoutUrl = null);
# End Meeting
Response End(string meetingId, string password);
# Get Meeting Informations
MeetingInfoResponse GetMeetingInfo(string meetingId, string password);
# Get Meetings (Active)
GetMeetingResponse GetMeetings();
# Get Records (Only published)
GetRecordingsResponse GetRecordings(string meetingId = null);
# Meeting Status Control
IsMeetingRunningResponse IsMeetingRunning(string meetingId);
# Meeting Join User
string Join(string meetingId, string name, string password, bool redirect = true);

# More Sample in the BigBlueButtonApi.Tests projects
# Sample
var bbb = new BigBlueButton("https://bbb.yoursite.com/bigbluebutton/api", "YOURSCRETKEY");
string meetingId = Guid.NewGuid().ToString().Sha512();
string mod_pas = Guid.NewGuid().ToString().Sha512();
string kat_pas = Guid.NewGuid().ToString().Sha512();
string name = "MeetName";
var response = _bbb.Create(meetingId, name, kat_pas, mod_pas, true, false, true, 76894, "Welcome", "https://www.returnedyoursitename.com.tr?q=Param1&t=Param2");
var attendee_res = _bbb.Join(meetingId, "Mesut Çakır", mod_pas);
Console.WriteLine("Your Link: " + attendee_res);
