using Online_Store.Domain.Entities.Products;

namespace Online_Store.Domain.Entities
{
    public class Category: AbstractModel
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
