using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButtonApi.Responses
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Attendee
    {
        private object _customdataField;

        private string _fullNameField;

        private bool _hasJoinedVoiceField;

        private bool _hasVideoField;

        private bool _isListeningOnlyField;

        private bool _isPresenterField;

        private string _roleField;

        private string _userIdField;

        /// <remarks />
        public string UserId
        {
            get { return _userIdField; }
            set { _userIdField = value; }
        }

        /// <remarks />
        public string FullName
        {
            get { return _fullNameField; }
            set { _fullNameField = value; }
        }

        /// <remarks />
        public string Role
        {
            get { return _roleField; }
            set { _roleField = value; }
        }

        /// <remarks />
        public bool IsPresenter
        {
            get { return _isPresenterField; }
            set { _isPresenterField = value; }
        }

        /// <remarks />
        public bool IsListeningOnly
        {
            get { return _isListeningOnlyField; }
            set { _isListeningOnlyField = value; }
        }

        /// <remarks />
        public bool HasJoinedVoice
        {
            get { return _hasJoinedVoiceField; }
            set { _hasJoinedVoiceField = value; }
        }

        /// <remarks />
        public bool HasVideo
        {
            get { return _hasVideoField; }
            set { _hasVideoField = value; }
        }

        /// <remarks />
        public object Customdata
        {
            get { return _customdataField; }
            set { _customdataField = value; }
        }
    }
}