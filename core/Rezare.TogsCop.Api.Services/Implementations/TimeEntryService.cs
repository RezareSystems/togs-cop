using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rezare.TogsCop.Integration.Toggl.Api.Models;
using TogglIntegration = Rezare.TogsCop.Integration.Toggl;

namespace Rezare.TogsCop.Api.Services.Implementations
{
    public class TimeEntryService : ITimeEntryService
    {
        private readonly TogglIntegration.Services.ITimeEntryService _apiService;

        public TimeEntryService(TogglIntegration.Services.ITimeEntryService apiService)
        {
            _apiService = apiService;
        }

        public Task<List<TimeEntry>> GetFromToggl(DateTimeOffset date, string apiKey)
        {
            var startDate = new DateTimeOffset(date.Date, date.Offset);
            var endDate = startDate
                            .AddHours(23)
                            .AddMinutes(59)
                            .AddSeconds(59);

            return _apiService.Get(startDate, endDate, apiKey);
        }

        public Task<List<TimeEntry>> GetTimeRecords(string apiKey, DateTime startDate, DateTime endDate)
        {
            return _apiService.Get(startDate, endDate, apiKey);
        }
    }
}
