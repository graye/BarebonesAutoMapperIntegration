using System.Collections.Generic;
using System.Threading.Tasks;

namespace BarebonesAutoMapperIntegration.Service.Contracts
{
    public interface IOrderService
    {
        void Add(Order po);
        
        Task<Order> GetAsync(int id);

        Task<OrderItem> GetItemAsync(int id);

        Task<IEnumerable<OrderItem>> GetItemsByOrderIdAsync(int id);

        Task<IEnumerable<Order>> GetListAsync(int count = 25, int skip = 0);
    }
}