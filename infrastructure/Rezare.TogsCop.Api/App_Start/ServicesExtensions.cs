using Rezare.TogsCop.Api.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            ServiceRegistry.RegisterServices(services);
        }
    }
}
