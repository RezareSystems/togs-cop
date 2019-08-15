using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Rezare.TogsCop.Integration.Toggl.Api;
using Rezare.TogsCop.Integration.Toggl.Api.Models;

namespace Rezare.TogsCop.Integration.Toggl.Services
{
    public class TimeEntryService : ITimeEntryService
    {
        private readonly ITogglApiFactory _apiFactory;
        private readonly HttpClient _client;

        public TimeEntryService(ITogglApiFactory apiFactory, HttpClient httpClient)
        {
            _apiFactory = apiFactory;
            _client = httpClient;
        }

        public async Task<List<TimeEntry>> Get(DateTimeOffset startDate, DateTimeOffset endDate, string apiKey)
        {
            _client.BaseAddress = new Uri("https://www.toggl.com/api/v8/");
            _client.DefaultRequestHeaders.Authorization = GenerateAuthorizationHeader(apiKey);

            var startDateStr = HttpUtility.UrlEncode(startDate.ToString("o"));
            var endDateStr = HttpUtility.UrlEncode(endDate.ToString("o"));

            var url = $"time_entries?start_date={startDateStr}&end_date={endDateStr}";

            var response = await _client.GetAsync(url);
            var responseStr = await response.Content.ReadAsStringAsync();
            var entries = JsonConvert.DeserializeObject<List<TimeEntry>>(responseStr);

            return entries;
        }

        private AuthenticationHeaderValue GenerateAuthorizationHeader(string apiKey)
        {
            var authStr = $"{apiKey}:api_token";
            var authStrBytes = Encoding.UTF8.GetBytes(authStr);
            var authStrBase64 = System.Convert.ToBase64String(authStrBytes);

            return new AuthenticationHeaderValue("Basic", authStrBase64);
        }
    }
}
