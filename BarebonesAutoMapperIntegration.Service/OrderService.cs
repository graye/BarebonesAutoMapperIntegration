using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BarebonesAutoMapperIntegration.Repository;
using BarebonesAutoMapperIntegration.Repository.Entities;
using BarebonesAutoMapperIntegration.Repository.Mocks;
using BarebonesAutoMapperIntegration.Service.Contracts;

namespace BarebonesAutoMapperIntegration.Service
{
    internal class OrderService : IOrderService
    {
        private readonly IRepository<OrderEntity> _orderRepository;
        private readonly IRepository<OrderItemEntity> _orderItemRepository;

        private IMapper Mapper { get; } = MapperConfig.Default.CreateMapper();
        

        public OrderService(IRepository<OrderEntity> orderRepository, IRepository<OrderItemEntity> orderItemRepository)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
        }
        
        public void Add(Order po)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Order> GetAsync(int id)
        {
            var single = await _orderRepository.AsQueryable().SingleOrDefaultAsync(po => po.Id == id);
            
            return Map<Order>(single);
        }

        public async Task<OrderItem> GetItemAsync(int id)
        {
            var single = await _orderItemRepository.AsQueryable().SingleOrDefaultAsync(o => o.Id == id);

            return Map<OrderItem>(single);
        }

        public async Task<IEnumerable<OrderItem>> GetItemsByOrderIdAsync(int id)
        {
            var list = await _orderRepository.AsQueryable().SingleOrDefaultAsync(o => o.Id == id);

            return Map<IEnumerable<OrderItem>>(list.OrderItems);
        }

        public async Task<IEnumerable<Order>> GetListAsync(int count = 25, int skip = 0)
        {
            var list = await _orderRepository.AsQueryable().Skip(skip).Take(count).ToListAsync();
            
            return Map<IEnumerable<Order>>(list);
        }

        private TResult Map<TResult>(object source)
        {
            return Mapper.Map<TResult>(source);
        }
    }
}