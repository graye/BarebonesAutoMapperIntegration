using System.Collections.Generic;

namespace BarebonesAutoMapperIntegration.ApiModels
{
    public class Order
    {
        public int Id { get; set; }
        
        public string Author { get; set; }
        
        public ICollection<OrderItem> OrderItems { get; set; }

        public int Count => OrderItems.Count;
    }
}