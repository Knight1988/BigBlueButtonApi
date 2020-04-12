using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BigBlueButtonApi.Responses
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
    public class Response
    {
        [XmlElement("returncode")]
        public string ReturnCode { get; set; }
        [XmlElement("version")]
        public string Version { get; set; }
        [XmlElement("messageKey")]
        public string MessageKey { get; set; }
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Convert xml to object
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T Parse<T>(string xml) where T : Response
        {
            return XmlSerializeHelper.Deserialize<T>(xml);
            //var jResponse = ToJObject(xml);
            //return JsonConvert.DeserializeObject<T>(jResponse["response"].ToString());
        }

        ///// <summary>
        /////     Convert xml to JObject
        ///// </summary>
        ///// <param name="xml"></param>
        ///// <returns></returns>
        //public static JObject ToJObject(string xml)
        //{
        //    var doc = new XmlDocument();
        //    doc.LoadXml(xml);

        //    var jsonText = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);

        //    return JObject.Parse(jsonText);
        //}
    }
}