using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Rezare.TogsCop.Integration.Toggl.Api;

namespace Rezare.TogsCop.Api.Services.Toggl
{
    public class TogglSettingsService : ITogglApiSettingsService
    {
        private readonly IConfiguration _configuration;

        private TogglApiSettings _settings;

        public TogglSettingsService(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public Task<TogglApiSettings> Get()
        {
            if (_settings == null) 
            {
                _settings = new TogglApiSettings
                {
                    WebServiceUrl = _configuration["Toggl:WebServiceUrl"]
                };
            }

            return Task.FromResult(_settings);
        }
    }
}
