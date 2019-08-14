using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace Rezare.TogsCop.Integration.Toggl.Api
{
    public class TogglApiFactory : ITogglApiFactory
    {
        private readonly ITogglApiSettingsService _settingsService;
        private readonly HttpClient _client;

        public TogglApiFactory(
            ITogglApiSettingsService settingsService,
            HttpClient client) 
        {
            _settingsService = settingsService;
            _client = client;
        }

        public async Task<T> Create<T>(string apiKey) where T : ITogglApi
        {
            await ConfigureClient(apiKey);

            return RestService.For<T>(_client);
        }

        private async Task ConfigureClient(string apiKey) 
        {
            var settings = await _settingsService.Get();

            _client.BaseAddress = new Uri(settings.WebServiceUrl);
            _client.DefaultRequestHeaders.Add("Authorization", GenerateAuthorizationHeader(apiKey).ToString());
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
