using System.Linq;
using BarebonesAutoMapperIntegration.Repository.Entities;
using BarebonesAutoMapperIntegration.Repository.Mocks;
using Microsoft.Extensions.DependencyInjection;

namespace BarebonesAutoMapperIntegration.Repository
{
    public static class Services
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<IRepository<OrderEntity>, OrderRepository>(s => new OrderRepository(MockData.GetOrders()));

            services.AddTransient<IRepository<OrderItemEntity>, OrderItemRepository>(s =>
                new OrderItemRepository(MockData.GetOrders().SelectMany(o => o.OrderItems)));
        }
    }
}