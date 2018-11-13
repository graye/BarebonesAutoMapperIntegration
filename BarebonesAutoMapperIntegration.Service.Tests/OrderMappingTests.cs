using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BarebonesAutoMapperIntegration.Repository;
using BarebonesAutoMapperIntegration.Repository.Entities;
using BarebonesAutoMapperIntegration.Service.Contracts;
using Xunit;

namespace BarebonesAutoMapperIntegration.Service.Tests
{
    public class OrderMappingTests
    {
        private static IConfigurationProvider MapperConfig { get; } = Service.MapperConfig.Default;

        private static IMapper GetMapper() => MapperConfig.CreateMapper();

        [Fact]
        public void Mapper_IncludesOrderBaseProperties()
        {
            var mockEntity = new OrderEntity
            {
                UpdatedAt = new DateTime(2011, 12, 10, 3, 2, 1)
            };

            var mockDto = GetMapper().Map<Order>(mockEntity);
            
            Assert.Equal(mockEntity.UpdatedAt, mockDto.UpdatedAt);
        }
        
        [Fact]
        public void Mapper_IncludesOrderItemBaseProperties()
        {
            var mockEntity = new OrderItemEntity
            {
                UpdatedAt = new DateTime(2011, 12, 10, 3, 2, 1)
            };

            var mockDto = GetMapper().Map<OrderItem>(mockEntity);
            
            Assert.Equal(mockEntity.UpdatedAt, mockDto.UpdatedAt);
        }
        
        [Fact]
        public void Mapper_IncludesOrder()
        {
            var entity = new OrderEntity
            {
                Id = 3,
                AuthorFirstName = "Gail",
                AuthorSurname = "Wallingo",
                OrderItems = new List<OrderItemEntity>
                {
                    new OrderItemEntity
                    {
                        Id = 2,
                        Name = "Soy"
                    }
                }
            };

            var apiModel = GetMapper().Map<Order>(entity);

            Assert.Equal(entity.Id, apiModel.Id);
            Assert.Equal($"{entity.AuthorFirstName} {entity.AuthorSurname}", apiModel.Author);
            
            // Automapper will map inner properties too
            Assert.Equal(entity.OrderItems.Count, apiModel.OrderItems.Count);
            Assert.Equal(entity.OrderItems.ElementAt(0).Id, apiModel.OrderItems.ElementAt(0).Id);
            Assert.Equal(entity.OrderItems.ElementAt(0).Name, apiModel.OrderItems.ElementAt(0).Name);
        }

        [Fact]
        public void Mapper_IncludesOrderItem()
        {
            var entity = new OrderItemEntity
            {
                Id = 12,
                Name = "Doge"
            };

            var apiModel = GetMapper().Map<OrderItem>(entity);
            
            Assert.Equal(entity.Id, apiModel.Id);
            Assert.Equal(entity.Name, apiModel.Name);
        }

        [Fact]
        public void Mapper_MapsEnumerables()
        {
            var entities = new List<OrderEntity>
            {
                new OrderEntity
                {
                    Id = 3,
                    AuthorFirstName = "Gail",
                    AuthorSurname = "Wallingo"
                },
                new OrderEntity
                {
                    Id = 2,
                    AuthorFirstName = "Jane",
                    AuthorSurname = "Doe"
                },
            };
            
            var modelList = GetMapper().Map<IEnumerable<Order>>(entities).ToArray();
            
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