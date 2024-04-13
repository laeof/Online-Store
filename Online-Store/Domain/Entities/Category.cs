using System.ComponentModel.DataAnnotations.Schema;
using Online_Store.Domain.Entities.Products;

namespace Online_Store.Domain.Entities
{
    public class Category: AbstractModel
    {
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public Guid? CategoryParentId { get; set; }
        [ForeignKey("CategoryParentId")]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
