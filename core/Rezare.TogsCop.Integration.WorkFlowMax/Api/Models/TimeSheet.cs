using System.Xml.Serialization;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api.Models
{
    public class TimeSheet
    {
        [XmlElement("ID")]
        public int Id { get; set; }
        public string Job { get; set; }
        public int Task { get; set; }
        public int Staff { get; set; }
        // should in yyyyMMdd format
        public string Date { get; set; }
        public int Minutes { get; set; }
        public string Note { get; set; }
    }
}
