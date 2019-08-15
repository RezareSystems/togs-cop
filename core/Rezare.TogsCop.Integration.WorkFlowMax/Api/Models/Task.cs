using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api.Models
{
    public class Task
    {
        [XmlElement("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
        public List<Staff> Assigned { get; set; }

        //public string Description { get; set; }
        //public int EstimatedMinutes { get; set; }
        //public int ActualMinutes { get; set; }
        //public bool Billable { get; set; }
        //public DateTime? StartDate { get; set; }
        //public DateTime? EndDate { get; set; }
        
    }
}
