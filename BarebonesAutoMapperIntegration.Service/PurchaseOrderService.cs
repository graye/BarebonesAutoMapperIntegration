using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BarebonesAutoMapperIntegration.ApiModels;
using BarebonesAutoMapperIntegration.Repository;

namespace BarebonesAutoMapperIntegration.Service
{
    internal class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IRepository<PurchaseOrderEntity> _repo;

        private IMapper Mapper { get; } = MapperConfig.Default.CreateMapper();
        

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

        public IEnumerable<PurchaseOrder> GetList(int count = 25)
        {
            return Mapper.Map<IEnumerable<PurchaseOrder>>(_repo.AsQueryable().Take(count));
        }
    }
}