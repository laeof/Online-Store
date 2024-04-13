using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;

namespace Online_Store.Models
{
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public string CategoryParentId { get; set; }
    }
}
