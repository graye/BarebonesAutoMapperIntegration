using System.Collections;
using System.Collections.Generic;
using BarebonesAutoMapperIntegration.ApiModels;

namespace BarebonesAutoMapperIntegration.Service
{
    public interface IPurchaseOrderService
    {
        void Add(PurchaseOrder po);

        PurchaseOrder Get(int id);

        IEnumerable<PurchaseOrder> GetList(int count = 25);
    }
}