using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BarebonesAutoMapperIntegration.ApiModels;

namespace BarebonesAutoMapperIntegration.Service
{
    public interface IPurchaseOrderService
    {
        void Add(PurchaseOrder po);

        PurchaseOrder Get(int id);

        Task<PurchaseOrder> GetAsync(int id);

        Task<IEnumerable<PurchaseOrder>> GetListAsync(int count = 25);
    }
}