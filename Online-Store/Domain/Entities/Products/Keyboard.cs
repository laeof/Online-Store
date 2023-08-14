using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities.Products
{
    [Table("Keyboards")]
    public class Keyboard: Product
    {
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
