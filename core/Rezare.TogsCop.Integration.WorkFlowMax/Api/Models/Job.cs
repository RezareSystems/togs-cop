using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api.Models
{
    public class Job
    {
        [XmlElement("ID")]
        public string Id { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        public Client Client { get; set; }
        public DateTime CompletedDate { get; set; }
        public List<Staff> Assigned { get; set; }
        public List<Task> Tasks { get; set; }

        //public Partner Partner { get; set; }
        //public Manager Manager { get; set; }
        //public string Description { get; set; }
        //public string State { get; set; }
        //public string ClientOrderNumber { get; set; }
        //public string Type { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime DueDate { get; set; }
        //public string InternalID { get; set; }
    }
}
