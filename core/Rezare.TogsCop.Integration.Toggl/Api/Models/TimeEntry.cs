using System;
using System.Collections.Generic;

namespace Rezare.TogsCop.Integration.Toggl.Api.Models
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? WorkspaceId { get; set; }
        public int? ProjectId { get; set; }
        public int? TaskId { get; set; }
        public bool Billable { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public int Duration { get; set; }
        public string CreatedWith { get; set; }
        public List<string> Tags { get; set; }
        public bool DurationOnly { get; set; }
        public DateTime At { get; set; }
    }
}
