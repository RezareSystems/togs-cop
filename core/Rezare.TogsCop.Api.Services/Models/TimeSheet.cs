using System;
using System.Collections.Generic;
using System.Text;

namespace Rezare.TogsCop.Api.Services.Models
{
    public class TimeSheet
    {
        public int Id { get; set; }
        //public int ID { get; set; }
        public string Job { get; set; }
        public int Task { get; set; }
        public int Staff { get; set; }
        // should in yyyyMMdd format
        public string Date { get; set; }
        public int Minutes { get; set; }
        public string Note { get; set; }
    }
}
