using System;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api
{
    public class WorkFlowMaxApiFactory : IWorkFlowMaxApiFactory
    {
        private readonly IWorkFlowMaxSettingsService _settingsService;

        private HttpClient _client = null;
        private RefitSettings _settings = null;


        public WorkFlowMaxApiFactory(IWorkFlowMaxSettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public async Task<T> Create<T>() where T : IWorkFlowMaxApi
        {
            if (_client == null)
            {
                _client = await CreateClient();
            }

            if (_settings == null)
            {
                _settings = CreateSettings();
            }

            return RestService.For<T>(_client, _settings);
        }

        private async Task<HttpClient> CreateClient()
        {
            var settings = await _settingsService.Get();
            var nativeHandler = new HttpClientHandler();
            var authHandler = new AuthenticatedHttpClientHandler(nativeHandler, _settingsService.Get);

            return new HttpClient(authHandler)
            {
                BaseAddress = new Uri(settings.WebServiceUrl)
            };
        }

        private RefitSettings CreateSettings()
        {
            return new RefitSettings
            {
                ContentSerializer = new XmlContentSerializer()
            };
        }
    }
}
