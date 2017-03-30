using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButtonApi.Responses
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class CreateResponse : Response
    {
        private string _attendeePwField;

        private string _createDateField;

        private ulong _createTimeField;

        private string _dialNumberField;

        private byte _durationField;

        private bool _hasBeenForciblyEndedField;

        private bool _hasUserJoinedField;

        private string _internalMeetingIdField;

        private string _meetingIdField;

        private string _messageField;

        private string _messageKeyField;

        private string _moderatorPwField;

        private object _parentMeetingIdField;

        private uint _voiceBridgeField;

        /// <remarks />
        public string MeetingId
        {
            get { return _meetingIdField; }
            set { _meetingIdField = value; }
        }

        /// <remarks />
        public string InternalMeetingId
        {
            get { return _internalMeetingIdField; }
            set { _internalMeetingIdField = value; }
        }

        /// <remarks />
        public object ParentMeetingId
        {
            get { return _parentMeetingIdField; }
            set { _parentMeetingIdField = value; }
        }

        /// <remarks />
        public string AttendeePw
        {
            get { return _attendeePwField; }
            set { _attendeePwField = value; }
        }

        /// <remarks />
        public string ModeratorPw
        {
            get { return _moderatorPwField; }
            set { _moderatorPwField = value; }
        }

        /// <remarks />
        public ulong CreateTime
        {
            get { return _createTimeField; }
            set { _createTimeField = value; }
        }

        /// <remarks />
        public uint VoiceBridge
        {
            get { return _voiceBridgeField; }
            set { _voiceBridgeField = value; }
        }

        /// <remarks />
        public string DialNumber
        {
            get { return _dialNumberField; }
            set { _dialNumberField = value; }
        }

        /// <remarks />
        public string CreateDate
        {
            get { return _createDateField; }
            set { _createDateField = value; }
        }

        /// <remarks />
        public bool HasUserJoined
        {
            get { return _hasUserJoinedField; }
            set { _hasUserJoinedField = value; }
        }

        /// <remarks />
        public byte Duration
        {
            get { return _durationField; }
            set { _durationField = value; }
        }

        /// <remarks />
        public bool HasBeenForciblyEnded
        {
            get { return _hasBeenForciblyEndedField; }
            set { _hasBeenForciblyEndedField = value; }
        }

        /// <remarks />
        public string MessageKey
        {
            get { return _messageKeyField; }
            set { _messageKeyField = value; }
        }

        /// <remarks />
        public string Message
        {
            get { return _messageField; }
            set { _messageField = value; }
        }
    }
}