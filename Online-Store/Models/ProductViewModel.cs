using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;

namespace Online_Store.Models
{
    public class ProductViewModel: Product
    {
        public Domain.Entities.Products.Monitor? Monitor { get; set; } = new Domain.Entities.Products.Monitor();
        public Keyboard? Keyboard { get; set; } = new Keyboard();
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
