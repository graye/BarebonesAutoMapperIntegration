using AutoMapper;
using BarebonesAutoMapperIntegration.Repository;
using BarebonesAutoMapperIntegration.Repository.Entities;
using BarebonesAutoMapperIntegration.Service.Contracts;

namespace BarebonesAutoMapperIntegration.Service
{
    // Internal: mapper config should only be accessible by this project and it's associated test project
    // Use profiles to group mapping configurations for each category (eg. All data models related to
    // purchase order)
    internal class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            // Mapping base class properties
            CreateMap<EntityBase, DTOBase>()
                .Include<OrderEntity, Order>()
                .Include<OrderItemEntity, OrderItem>();
            
            CreateMap<OrderEntity, Order>()
                .ForMember(dest => dest.Author,
                opt => opt.MapFrom(source => $"{source.AuthorFirstName} {source.AuthorSurname}"))
                .ForMember(dest => dest.Unused, opt => opt.Ignore()); 
                // Must explicitly ignore unmapped destination properties
                // otherwise AssertConfigurationIsValid() will fail

            CreateMap<OrderItemEntity, OrderItem>();
        }
    }
}