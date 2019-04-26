using Rezare.TogsCop.Integration.WorkFlowMax.Api.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api.Responses
{
    [XmlRoot("Response")]
    public class StaffResponse
    {
        public string Status { get; set; }
        public List<Staff> StaffList { get; set; }
    }
}
