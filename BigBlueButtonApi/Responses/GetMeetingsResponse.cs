using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButtonApi.Responses
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class GetMeetingResponse : Response
    {
        public Meetings Meetings { get; set; }
    }
    [Serializable]
    public class Meetings
    {
        public List<Meeting> Meeting { get; set; }
    }
    [Serializable]
    public class Meeting
    {
        public string MeetingID { get; set; }

        public string MeetingName { get; set; }

        public long CreateTime { get; set; }

        public string AttendeePW { get; set; }

        public string ModeratorPW { get; set; }

        public bool Running { get; set; }

        public bool HasBeenForciblyEnded { get; set; }
    }
}