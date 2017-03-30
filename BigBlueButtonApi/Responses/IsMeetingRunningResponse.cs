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
    public class IsMeetingRunningResponse
    {
        private string _returncodeField;

        private bool _runningField;

        /// <remarks />
        public string Returncode
        {
            get { return _returncodeField; }
            set { _returncodeField = value; }
        }

        /// <remarks />
        public bool Running
        {
            get { return _runningField; }
            set { _runningField = value; }
        }
    }
}