using System.Collections.Generic;

namespace BarebonesAutoMapperIntegration.Repository.Entities
{
    public class OrderEntity : EntityBase
    {
        public int Id { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorSurname { get; set; }
        
        public ICollection<OrderItemEntity> OrderItems { get; set; }
    }
}