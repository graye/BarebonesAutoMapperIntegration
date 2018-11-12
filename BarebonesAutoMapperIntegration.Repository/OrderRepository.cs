using System;
using System.Collections.Generic;
using System.Linq;

namespace BarebonesAutoMapperIntegration.Repository
{
    internal class OrderRepository : IRepository<OrderEntity>
    {
        private readonly IEnumerable<OrderEntity> _entities;

        public OrderRepository(IEnumerable<OrderEntity> entities) => _entities = entities;
        
        public IQueryable<OrderEntity> AsQueryable() => _entities.AsQueryable();

        public void Add(OrderEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}