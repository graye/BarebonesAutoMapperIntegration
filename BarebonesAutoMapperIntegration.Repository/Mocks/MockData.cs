using System.Collections.Generic;
using BarebonesAutoMapperIntegration.Repository.Entities;

namespace BarebonesAutoMapperIntegration.Repository.Mocks
{
    internal sealed class MockData
    {
        public static IEnumerable<OrderEntity> GetOrders()
        {
            return new List<OrderEntity>
            {
                new OrderEntity
                {
                    Id = 1,
                    AuthorFirstName = "Jane",
                    AuthorSurname = "Doe",
                    OrderItems = new List<OrderItemEntity>()
                },
                new OrderEntity
                {
                    Id = 2,
                    AuthorFirstName = "Foo",
                    AuthorSurname = "Bar",
                    OrderItems = new List<OrderItemEntity>
                    {
                        new OrderItemEntity
                        {
                            Id = 1,
                            Name = "Corn"
                        },
                        new OrderItemEntity
                        {
                            Id = 2,
                            Name = "Flour"
                        },
                    }
                },
            };
        }
    }
}