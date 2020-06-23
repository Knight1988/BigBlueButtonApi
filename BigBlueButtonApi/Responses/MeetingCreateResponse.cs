using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButtonApi.Responses
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
    public class MeetingCreateResponse : Response
    {
        [XmlElement("meetingID")]
        public string MeetingId { get; set; }

        [XmlElement("internalMeetingID")]
        public string InternalMeetingId { get; set; }

        [XmlElement("parentMeetingID")]
        public string ParentMeetingId { get; set; }

        [XmlElement("attendeePW")]
        public string AttendeePw { get; set; }

        [XmlElement("moderatorPW")]
        public string ModeratorPw { get; set; }

        [XmlElement("createTime")]
        public ulong CreateTime { get; set; }

        [XmlElement("voiceBridge")]
        public uint VoiceBridge { get; set; }

        [XmlElement("dialNumber")]
        public string DialNumber { get; set; }
        [XmlElement("createDate")]
        public string CreateDate { get; set; }

        [XmlElement("hasUserJoined")]
        public bool HasUserJoined { get; set; }

        [XmlElement("duration")]
        public ulong Duration { get; set; }

        [XmlElement("hasBeenForciblyEnded")]
        public bool HasBeenForciblyEnded { get; set; }
    }
}