using System.Collections.Generic;

namespace Drawers.Domain.Entities
{
    public class Category
    {
        public Category() {
            Products = new HashSet<Product>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; private set; }
    }
}