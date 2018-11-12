using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BarebonesAutoMapperIntegration.ApiModels;
using BarebonesAutoMapperIntegration.Repository;
using BarebonesAutoMapperIntegration.Repository.Mocks;

namespace BarebonesAutoMapperIntegration.Service
{
    internal class OrderService : IOrderService
    {
        private readonly IRepository<OrderEntity> _repo;

        private IMapper Mapper { get; } = MapperConfig.Default.CreateMapper();
        

        public OrderService(IRepository<OrderEntity> repo)
        {
            _repo = repo;
        }
        
        public void Add(Order po)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Order> GetAsync(int id)
        {
            var single = await _repo.AsQueryable().SingleOrDefaultAsync(po => po.Id == id);
            
            return Mapper.Map<Order>(single);
        }

        public async Task<IEnumerable<Order>> GetListAsync(int count = 25, int skip = 0)
        {
            var list = await _repo.AsQueryable().Skip(skip).Take(count).ToListAsync();
            
            return Mapper.Map<IEnumerable<Order>>(list);
        }
    }
}