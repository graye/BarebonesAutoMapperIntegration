using BarebonesAutoMapperIntegration.ApiModels;
using BarebonesAutoMapperIntegration.Repository;

namespace BarebonesAutoMapperIntegration.Service
{
    internal class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IRepository<PurchaseOrderEntity> _repo;

        public PurchaseOrderService(IRepository<PurchaseOrderEntity> repo)
        {
            _repo = repo;
        }
        
        public void Add(PurchaseOrder po)
        {
            throw new System.NotImplementedException();
        }

        public PurchaseOrder Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}