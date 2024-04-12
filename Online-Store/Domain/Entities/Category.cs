using Online_Store.Domain.Entities.Products;

namespace Online_Store.Domain.Entities
{
    public class Category: AbstractModel
    {
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public Guid? CategoryParentId { get; set; }
        public ICollection<Category> Categories { get; } = new List<Category>();
        public ICollection<Product> Products { get; } = new List<Product>();
    }
}
