using System;

namespace Drawers.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ReleasedAt { get; set; } 
        public DateTime? Discontinued { get; set; } 
    }
}
