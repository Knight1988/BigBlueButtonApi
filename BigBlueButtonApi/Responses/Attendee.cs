using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButtonApi.Responses
{
    [Serializable]
    public class Attendee
    {
        [XmlElement("userID")]
        public string UserId { get; set; }

        [XmlElement("fullName")]
        public string FullName { get; set; }

        [XmlElement("role")]
        public string Role { get; set; }

        [XmlElement("isPresenter")]
        public bool IsPresenter { get; set; }

        [XmlElement("isListeningOnly")]
        public bool IsListeningOnly { get; set; }

        [XmlElement("hasJoinedVoice")]
        public bool HasJoinedVoice { get; set; }
        [XmlElement("hasVideo")]
        public bool HasVideo { get; set; }
        [XmlElement("clientType")]
        public object CustomData { get; set; }
    }
}