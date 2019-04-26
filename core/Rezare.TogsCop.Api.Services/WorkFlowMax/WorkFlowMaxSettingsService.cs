using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Rezare.TogsCop.Integration.WorkFlowMax.Api;

namespace Rezare.TogsCop.Api.Services.WorkFlowMax
{
    public class WorkFlowMaxSettingsService : IWorkFlowMaxSettingsService
    {
        private readonly IConfiguration _configuration;

        private WorkFlowMaxApiSettings _settings;

        public WorkFlowMaxSettingsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<WorkFlowMaxApiSettings> Get()
        {
            if (_settings == null)
            {
                _settings = new WorkFlowMaxApiSettings
                {
                    WebServiceUrl = _configuration["WorkFlowMax:WebServiceUrl"],
                    ApiKey = _configuration["WorkFlowMax:ApiKey"],
                    AccountKey = _configuration["WorkFlowMax:AccountKey"]
                };
            }

            return Task.FromResult(_settings);
        }
    }
}
