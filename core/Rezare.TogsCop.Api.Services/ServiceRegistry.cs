using Microsoft.Extensions.DependencyInjection;
using Rezare.TogsCop.Api.Services.Abstractions;
using Rezare.TogsCop.Api.Services.Implementations;

namespace Rezare.TogsCop.Api.Services
{
    public static class ServiceRegistry
    {
        public static void RegisterServices(IServiceCollection services)
        {
            WorkFlowMax.WorkFlowMaxServiceRegistry.RegisterServices(services);
            Toggl.TogglServiceRegistry.RegisterServices(services);

            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<ITimeEntryService, TimeEntryService>();
            services.AddScoped<IWfmTasksService, WfmTasksService>();
        }
    }
}
