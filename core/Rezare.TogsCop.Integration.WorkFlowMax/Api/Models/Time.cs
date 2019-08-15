using System;
using System.Xml.Serialization;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api.Models
{
    public class Time
    {
        [XmlElement("ID")]
        public int Id { get; set; }
        public Job Job { get; set; }
        public Task Task { get; set; }
        public Staff Staff { get; set; }
        public DateTime Date { get; set; }
        public int Minutes { get; set; }
        public string Note { get; set; }
        public bool Billable { get; set; }
        // below values are included if the time entry was record with a start and end time
        public string Start { get; set; }
        public string End { get; set; }
    }
}
