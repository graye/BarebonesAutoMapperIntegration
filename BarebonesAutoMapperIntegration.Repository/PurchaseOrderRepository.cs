using System;
using System.Collections.Generic;
using System.Linq;

namespace BarebonesAutoMapperIntegration.Repository
{
    internal class PurchaseOrderRepository : IRepository<PurchaseOrderEntity>
    {
        private readonly List<PurchaseOrderEntity> _entities;

        public PurchaseOrderRepository(List<PurchaseOrderEntity> entities) => _entities = entities;
        
        public IQueryable<PurchaseOrderEntity> AsQueryable() => _entities.AsQueryable();
    }
}