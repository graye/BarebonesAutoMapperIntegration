using Microsoft.Extensions.DependencyInjection;

namespace BarebonesAutoMapperIntegration.Service
{
    public static class Services
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            
            Repository.Services.RegisterDependencies(services);
        }
    }
}