using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities.Products
{
    public class Characteristics: AbstractModel
    {
        public string? Name { get; set; }
        public string? Value { get; set; }
        public double? DoubleValue { get; set; }
        public ICollection<Product> Products { get; } = new List<Product>();
    }
}
