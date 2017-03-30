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
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Response
    {
        /// <remarks />
        public string ReturnCode { get; set; }

        /// <remarks />
        public string Version { get; set; }

        /// <summary>
        /// Convert xml to object
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T Parse<T>(string xml) where T : Response
        {
            var jResponse = ToJObject(xml);
            return JsonConvert.DeserializeObject<T>(jResponse["response"].ToString());
        }

        /// <summary>
        /// Convert xml to JObject
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static JObject ToJObject(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var jsonText = JsonConvert.SerializeXmlNode(doc);

            return JObject.Parse(jsonText);
        }
    }
}