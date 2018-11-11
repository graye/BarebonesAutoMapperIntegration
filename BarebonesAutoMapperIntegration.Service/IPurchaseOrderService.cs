using BarebonesAutoMapperIntegration.ApiModels;

namespace BarebonesAutoMapperIntegration.Service
{
    public interface IPurchaseOrderService
    {
        void Add(PurchaseOrder po);

        PurchaseOrder Get(int id);
    }
}