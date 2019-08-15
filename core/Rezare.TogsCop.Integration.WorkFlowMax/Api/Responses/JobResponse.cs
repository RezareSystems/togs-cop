using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Models;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api.Responses
{
    [XmlRoot("Response")]
    public class JobResponse
    {
        public string Status { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
