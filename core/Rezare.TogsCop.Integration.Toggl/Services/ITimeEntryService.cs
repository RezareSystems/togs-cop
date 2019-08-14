using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rezare.TogsCop.Integration.Toggl.Api.Models;

namespace Rezare.TogsCop.Integration.Toggl.Services
{
    public interface ITimeEntryService
    {
        Task<List<TimeEntry>> Get(DateTimeOffset startDate, DateTimeOffset endDate, string apiKey);
    }
}
