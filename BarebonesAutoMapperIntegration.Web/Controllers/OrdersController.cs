using System.Collections.Generic;
using System.Threading.Tasks;
using BarebonesAutoMapperIntegration.ApiModels;
using BarebonesAutoMapperIntegration.Service;
using BarebonesAutoMapperIntegration.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BarebonesAutoMapperIntegration.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService) =>
            _orderService = orderService;
        
        
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Order>> Get()
        {
            return await _orderService.GetListAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Order> Get(int id)
        {
            return await _orderService.GetAsync(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}