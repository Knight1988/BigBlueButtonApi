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
    public class IsMeetingRunningResponse : Response
    {
        private bool _runningField;

        /// <remarks />
        public bool Running
        {
            get { return _runningField; }
            set { _runningField = value; }
        }
    }
}