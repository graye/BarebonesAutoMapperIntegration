using BarebonesAutoMapperIntegration.Repository.Mocks;
using Microsoft.Extensions.DependencyInjection;

namespace BarebonesAutoMapperIntegration.Repository
{
    public static class Services
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<IRepository<OrderEntity>, OrderRepository>(s => new OrderRepository(MockData.GetOrders()));
        }
    }
}