using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities.Products
{
    public class ProductImages: AbstractModel
    {
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public string FileName { get; set; }
    }
}
