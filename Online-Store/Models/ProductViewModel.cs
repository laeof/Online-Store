using Online_Store.Domain.Entities;

namespace Online_Store.Models
{
    public class ProductViewModel: Product
    {
        public IEnumerable<Product>? Products { get; set; }
    }
}
