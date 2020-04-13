using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButtonApi.Responses
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
    public class IsMeetingRunningResponse : Response
    {
        [XmlElement("running")]
        public bool Running { get; set; }
    }
}