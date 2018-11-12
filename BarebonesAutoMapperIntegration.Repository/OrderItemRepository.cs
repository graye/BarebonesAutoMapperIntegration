using System.Collections.Generic;
using System.Linq;
using BarebonesAutoMapperIntegration.Repository.Entities;

namespace BarebonesAutoMapperIntegration.Repository
{
    internal class OrderItemRepository : IRepository<OrderItemEntity>
    {
        private readonly IEnumerable<OrderItemEntity> _entities;

        public OrderItemRepository(IEnumerable<OrderItemEntity> entities) =>
            _entities = entities;
        
        public IQueryable<OrderItemEntity> AsQueryable()
        {
            throw new System.NotImplementedException();
        }

        public void Add(OrderItemEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}