using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;

namespace Online_Store.Models
{
    public class ProductViewModel: Product
    {
        public Domain.Entities.Products.Monitor? Monitor { get; set; }
        public Keyboard? Keyboard { get; set; }
        //public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
