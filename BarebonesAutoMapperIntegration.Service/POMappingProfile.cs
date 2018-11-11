using AutoMapper;
using BarebonesAutoMapperIntegration.ApiModels;
using BarebonesAutoMapperIntegration.Repository;

namespace BarebonesAutoMapperIntegration.Service
{
    public class POMappingProfile : Profile
    {
        public POMappingProfile()
        {
            CreateMap<PurchaseOrderEntity, PurchaseOrder>();
        }
    }
}