using System.Xml.Serialization;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api.Models
{
    public class Staff
    {
        [XmlElement("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int AllocatedMinutes { get; set; }
    }
}
