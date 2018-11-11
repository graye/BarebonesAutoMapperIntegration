using AutoMapper;
using BarebonesAutoMapperIntegration.ApiModels;
using BarebonesAutoMapperIntegration.Repository;

namespace BarebonesAutoMapperIntegration.Service
{
    // Internal: mapper config should only be accessible by this project and it's associated test project
    // Use profiles to group mapping configurations for each category (eg. All data models related to
    // purchase order)
    internal class POMappingProfile : Profile
    {
        public POMappingProfile()
        {
            CreateMap<PurchaseOrderEntity, PurchaseOrder>().ForMember(dest => dest.Author,
                opt => opt.MapFrom(source => $"{source.AuthorFirstName} {source.AuthorSurname}"));
        }
    }
}