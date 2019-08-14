using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rezare.TogsCop.Integration.Toggl.Api.Models;

namespace Rezare.TogsCop.Api.Services
{
    public interface ITimeEntryService
    {
        Task<List<TimeEntry>> GetFromToggl(DateTimeOffset date, string apiKey);
    }
}
