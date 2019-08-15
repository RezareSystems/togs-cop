using Microsoft.Extensions.DependencyInjection;
using WorkFlowMaxIntegration = Rezare.TogsCop.Integration.WorkFlowMax;

namespace Rezare.TogsCop.Api.Services.WorkFlowMax
{
    public static class WorkFlowMaxServiceRegistry
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<WorkFlowMaxIntegration.Api.IWorkFlowMaxSettingsService, WorkFlowMaxSettingsService>();
            services.AddSingleton<WorkFlowMaxIntegration.Api.IWorkFlowMaxApiFactory, WorkFlowMaxIntegration.Api.WorkFlowMaxApiFactory>();
            services.AddScoped<WorkFlowMaxIntegration.Services.IStaffService, WorkFlowMaxIntegration.Services.StaffService>();
            services
                .AddScoped<WorkFlowMaxIntegration.Services.IWfmJobsService,
                    WorkFlowMaxIntegration.Services.WfmJobsService>();
        }
    }
}
