using Online_Store.Domain.Entities.Products;
using Online_Store.Domain.Entities;
using Online_Store.Models;
using Online_Store.Domain;

namespace Factories
{
    public class KeyboardFactory: ProductFactory<Keyboard>
    {
        public KeyboardFactory(DataManager dataManager) : base(dataManager)
        {

        }

        public override async Task<Product> CreateProduct(ProductViewModel model)
        {
            return new Keyboard();
        }
    }
}
