using Microsoft.Extensions.DependencyInjection;
using TogglIntegration = Rezare.TogsCop.Integration.Toggl;

namespace Rezare.TogsCop.Api.Services.Toggl
{
    public static class TogglServiceRegistry
    {
        public static void RegisterServices(IServiceCollection services) 
        {
            services.AddHttpClient<TogglIntegration.Api.ITogglApiFactory, TogglIntegration.Api.TogglApiFactory>();

            services.AddSingleton<TogglIntegration.Api.ITogglApiSettingsService, TogglSettingsService>();
            //services.AddScoped<TogglIntegration.Api.ITogglApiFactory, TogglIntegration.Api.TogglApiFactory>();
            services.AddScoped<TogglIntegration.Services.ITimeEntryService, TogglIntegration.Services.TimeEntryService>();
        }
    }
}
