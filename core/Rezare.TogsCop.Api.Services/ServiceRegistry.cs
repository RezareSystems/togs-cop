using Microsoft.Extensions.DependencyInjection;

namespace Rezare.TogsCop.Api.Services
{
    public static class ServiceRegistry
    {
        public static void RegisterServices(IServiceCollection services)
        {
            WorkFlowMax.WorkFlowMaxServiceRegistry.RegisterServices(services);
        }
    }
}
