using Online_Store.Domain.Entities.Products;
using Online_Store.Domain.Entities;
using Online_Store.Models;
using Online_Store.Domain;

namespace Online_Store
{
    
    public class KeyboardFactory: IProductFactory
    {
        private readonly DataManager _dataManager;
        public KeyboardFactory(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public async Task<Product> CreateProduct(ProductViewModel model)
        {
            var product = new Keyboard
            {
                Name = model.Name,
                Price = model.Price,
                CategoryId = model.CategoryId,
            };

            await _dataManager.Products.SaveProductAsync(product);

            return product;
        }
    }
}
