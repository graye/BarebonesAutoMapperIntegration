using System.Collections.Generic;

namespace BarebonesAutoMapperIntegration.Repository.Mocks
{
    internal sealed class MockData
    {
        public static IEnumerable<OrderEntity> GetOrders()
        {
            return new List<OrderEntity>
            {

            };
        }
    }
}