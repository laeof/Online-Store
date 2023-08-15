using Online_Store.Domain.Entities;
using Online_Store.Models;

namespace Online_Store
{
    public interface IProductFactory
    {
        Task<Product> CreateProduct(ProductViewModel model);
    }
}
