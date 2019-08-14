using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Rezare.TogsCop.Integration.Toggl.Api.Models;

namespace Rezare.TogsCop.Integration.Toggl.Api
{
    public interface ITimeEntryApi : ITogglApi
    {
        [Get("/time_entries")]
        Task<List<TimeEntry>> Get([AliasAs("start_date")] string startDate, [AliasAs("end_date")] string endDate);
    }
}
