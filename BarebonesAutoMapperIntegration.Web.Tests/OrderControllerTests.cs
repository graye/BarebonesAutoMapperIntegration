using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarebonesAutoMapperIntegration.Service.Contracts;
using BarebonesAutoMapperIntegration.Web.Controllers;
using NSubstitute;
using Xunit;

namespace BarebonesAutoMapperIntegration.Web.Tests
{
    public class OrderControllerTests
    {
        private readonly IOrderService _mockOrderService;
        
        public OrderControllerTests()
        {
            _mockOrderService = Substitute.For<IOrderService>();
        }
        
        [Fact]
        public async Task Test1()
        {
            // Arrange
            var orderList = new List<Order>();
            _mockOrderService.GetListAsync().Returns(call => orderList);
            var controller = new OrdersController(_mockOrderService);
            
            // Act
            var list = await controller.Get();
            
            // Assert
            Assert.Equal(orderList.Count, list.Count());
        }
    }
}