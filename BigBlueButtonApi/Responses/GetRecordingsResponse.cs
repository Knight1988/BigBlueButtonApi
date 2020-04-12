using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BigBlueButtonApi.Responses
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "response", IsNullable = false, Namespace = "")]
    public class GetRecordingsResponse : Response
    {
        [XmlArray("recordings")]
        [XmlArrayItem("recording")]
        public List<Recording> Recordings { get; set; }
    }

    [Serializable]
    public class Recording
    {
        [XmlElement("recordID")]
        public string RecordID { get; set; }
        [XmlElement("meetingID")]
        public string MeetingID { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("published")]
        public bool Published { get; set; }
        [XmlElement("isBreakout")]
        public bool IsBreakout { get; set; }
        [XmlElement("startTime")]
        public long StartTime { get; set; }
        [XmlElement("endTime")]
        public long EndTime { get; set; }
        [XmlArray("playback")]
        [XmlArrayItem("format")]
        public List<Format> Playbacks { get; set; }

        [XmlElement("participants")]
        public int Participants { get; set; }
        [XmlElement("rawSize")]
        public long RawSize { get; set; }
    }

    [Serializable]
    public class Format
    {
        [XmlElement("type")]
        public string Type { get; set; }
        [XmlElement("url")]
        public string Url { get; set; }
        [XmlElement("length")]
        public long Length { get; set; }
        [XmlElement("size")]
        public long Size { get; set; }

        [XmlElement("preview")]
        public PreviewImage Preview { get; set; }
    }
    [Serializable]
    public class PreviewImage
    {
        [XmlArray("images")]
        [XmlArrayItem("image")]
        public List<PreviewImageItem> Images { get; set; }
    }
    [Serializable]
    public class PreviewImageItem
    {
        [XmlAttribute("alt")]
        public string Title { get; set; }

        [XmlElement("image")]
        public string Url { get; set; }
    }
}