using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButtonApi.Responses
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Attendees
    {
        private Attendee _attendeeField;

        /// <remarks />
        public Attendee Attendee
        {
            get { return _attendeeField; }
            set { _attendeeField = value; }
        }
    }
}