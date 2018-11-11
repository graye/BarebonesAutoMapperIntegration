using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return Mapper.Map<PurchaseOrder>(_repo.AsQueryable().SingleOrDefault(po => po.Id == id));
        }

        public async Task<PurchaseOrder> GetAsync(int id)
        {
            return Mapper.Map<PurchaseOrder>(await _repo.AsQueryable().SingleOrDefaultAsync(po => po.Id == id));
        }

        public async Task<IEnumerable<PurchaseOrder>> GetListAsync(int count = 25)
        {
            return Mapper.Map<IEnumerable<PurchaseOrder>>(await _repo.AsQueryable().Take(count).ToListAsync());
        }
    }
}