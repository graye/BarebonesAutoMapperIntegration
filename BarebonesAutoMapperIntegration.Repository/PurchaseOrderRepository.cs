using System;
using System.Linq;

namespace BarebonesAutoMapperIntegration.Repository
{
    internal class PurchaseOrderRepository : IRepository<PurchaseOrderEntity>
    {
        public IQueryable<PurchaseOrderEntity> AsQueryable()
        {
            throw new NotImplementedException();
        }
    }
}