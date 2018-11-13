using System.Collections.Generic;

namespace BarebonesAutoMapperIntegration.Service.Contracts
{
    public class Order : DTOBase
    {
        public int Id { get; set; }
        
        public string Author { get; set; }
        
        public ICollection<OrderItem> OrderItems { get; set; }

        public int Count => OrderItems.Count;
        
        // Used to demonstrate ignored mappings, refer to OrderMappingProfile.cs
        public string Unused { get; set; }
    }
}