using Online_Store.Domain.Entities.Products;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class Product: AbstractModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public int? Amount { get; set; }
        public string? Size { get; set; }
        public string? Weight { get; set; }
        public string? Color { get; set; }
        public string? Country { get; set; }
        public string? Guarantee { get; set; }
        public string? Additional { get; set; }
        public string? Kit { get; set; }
        public ICollection<ProductImages> Images { get; set; } = new List<ProductImages>();
    }
}
