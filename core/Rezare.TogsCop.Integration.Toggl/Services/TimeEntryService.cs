using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rezare.TogsCop.Integration.Toggl.Api;
using Rezare.TogsCop.Integration.Toggl.Api.Models;

namespace Rezare.TogsCop.Integration.Toggl.Services
{
    public class TimeEntryService : ITimeEntryService
    {
        private readonly ITogglApiFactory _apiFactory;

        public TimeEntryService(ITogglApiFactory apiFactory)
        {
            _apiFactory = apiFactory;
        }

        public async Task<List<TimeEntry>> Get(DateTimeOffset startDate, DateTimeOffset endDate, string apiKey)
        {
            var api = await _apiFactory.Create<ITimeEntryApi>(apiKey);

            return await api.Get(startDate.ToString("o"), endDate.ToString("o"));
        }
    }
}
