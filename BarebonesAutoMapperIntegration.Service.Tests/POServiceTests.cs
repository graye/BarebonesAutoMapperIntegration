using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BarebonesAutoMapperIntegration.ApiModels;
using BarebonesAutoMapperIntegration.Repository;
using Xunit;

namespace BarebonesAutoMapperIntegration.Service.Tests
{
    public class POServiceTests
    {
        private static IConfigurationProvider MapperConfig { get; } = Service.MapperConfig.Default;

        private static IMapper GetMapper() => MapperConfig.CreateMapper();
        
        [Fact]
        public void Mapper_IncludesPurchaseOrder()
        {
            var entity = new PurchaseOrderEntity
            {
                Id = 3,
                AuthorFirstName = "Gail",
                AuthorSurname = "Wallingo"
            };

            var apiModel = GetMapper().Map<PurchaseOrder>(entity);

            Assert.Equal(entity.Id, apiModel.Id);
            Assert.Equal($"{entity.AuthorFirstName} {entity.AuthorSurname}", apiModel.Author);
        }

        [Fact]
        public void Mapper_MapsEnumerables()
        {
            var entities = new List<PurchaseOrderEntity>
            {
                new PurchaseOrderEntity
                {
                    Id = 3,
                    AuthorFirstName = "Gail",
                    AuthorSurname = "Wallingo"
                },
                new PurchaseOrderEntity
                {
                    Id = 2,
                    AuthorFirstName = "Jane",
                    AuthorSurname = "Doe"
                },
            };
            
            var modelList = GetMapper().Map<IEnumerable<PurchaseOrder>>(entities).ToArray();
            
            Assert.Equal(entities.Count, modelList.Length);

            for (var i = 0; i < entities.Count; i++)
            {
                var currentResult = modelList[i];
                Assert.Equal(entities[i].Id, currentResult.Id);
                Assert.Equal($"{entities[i].AuthorFirstName} {entities[i].AuthorSurname}", currentResult.Author);
            }
        }
    }
}