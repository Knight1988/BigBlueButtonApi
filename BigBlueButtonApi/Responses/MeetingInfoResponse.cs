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
    public class MeetingInfoResponse : Response
    {
        private string _attendeePwField;

        private Attendees _attendeesField;

        private string _createDateField;

        private ulong _createTimeField;

        private string _dialNumberField;

        private byte _durationField;

        private byte _endTimeField;

        private bool _hasBeenForciblyEndedField;

        private bool _hasUserJoinedField;

        private string _internalMeetingIdField;

        private bool _isBreakoutField;

        private byte _listenerCountField;

        private byte _maxUsersField;

        private string _meetingIdField;

        private string _meetingNameField;

        private object _messageField;

        private object _messageKeyField;

        private object _metadataField;

        private byte _moderatorCountField;

        private string _moderatorPwField;

        private byte _participantCountField;

        private bool _recordingField;

        private bool _runningField;

        private ulong _startTimeField;

        private byte _videoCountField;

        private uint _voiceBridgeField;

        private byte _voiceParticipantCountField;

        /// <remarks />
        public string MeetingName
        {
            get { return _meetingNameField; }
            set { _meetingNameField = value; }
        }

        /// <remarks />
        public bool IsBreakout
        {
            get { return _isBreakoutField; }
            set { _isBreakoutField = value; }
        }

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
        public ulong CreateTime
        {
            get { return _createTimeField; }
            set { _createTimeField = value; }
        }

        /// <remarks />
        public string CreateDate
        {
            get { return _createDateField; }
            set { _createDateField = value; }
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
        public bool Running
        {
            get { return _runningField; }
            set { _runningField = value; }
        }

        /// <remarks />
        public byte Duration
        {
            get { return _durationField; }
            set { _durationField = value; }
        }

        /// <remarks />
        public bool HasUserJoined
        {
            get { return _hasUserJoinedField; }
            set { _hasUserJoinedField = value; }
        }

        /// <remarks />
        public bool Recording
        {
            get { return _recordingField; }
            set { _recordingField = value; }
        }

        /// <remarks />
        public bool HasBeenForciblyEnded
        {
            get { return _hasBeenForciblyEndedField; }
            set { _hasBeenForciblyEndedField = value; }
        }

        /// <remarks />
        public ulong StartTime
        {
            get { return _startTimeField; }
            set { _startTimeField = value; }
        }

        /// <remarks />
        public byte EndTime
        {
            get { return _endTimeField; }
            set { _endTimeField = value; }
        }

        /// <remarks />
        public byte ParticipantCount
        {
            get { return _participantCountField; }
            set { _participantCountField = value; }
        }

        /// <remarks />
        public byte ListenerCount
        {
            get { return _listenerCountField; }
            set { _listenerCountField = value; }
        }

        /// <remarks />
        public byte VoiceParticipantCount
        {
            get { return _voiceParticipantCountField; }
            set { _voiceParticipantCountField = value; }
        }

        /// <remarks />
        public byte VideoCount
        {
            get { return _videoCountField; }
            set { _videoCountField = value; }
        }

        /// <remarks />
        public byte MaxUsers
        {
            get { return _maxUsersField; }
            set { _maxUsersField = value; }
        }

        /// <remarks />
        public byte ModeratorCount
        {
            get { return _moderatorCountField; }
            set { _moderatorCountField = value; }
        }

        /// <remarks />
        public Attendees Attendees
        {
            get { return _attendeesField; }
            set { _attendeesField = value; }
        }

        /// <remarks />
        public object Metadata
        {
            get { return _metadataField; }
            set { _metadataField = value; }
        }

        /// <remarks />
        public object MessageKey
        {
            get { return _messageKeyField; }
            set { _messageKeyField = value; }
        }

        /// <remarks />
        public object Message
        {
            get { return _messageField; }
            set { _messageField = value; }
        }
    }
}