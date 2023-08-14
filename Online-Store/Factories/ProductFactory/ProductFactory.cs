using Online_Store.Domain.Entities.Products;
using Online_Store.Domain.Entities;
using Online_Store.Domain;
using Online_Store.Models;

namespace Factories
{
    public class ProductFactory<TProduct> where TProduct : Product
    {
        private readonly DataManager _dataManager;
        public ProductFactory(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public virtual async Task<Product> CreateProduct(ProductViewModel model)
        {
            var product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                Additional = model.Additional,
                Color = model.Color,
                Price = model.Price,
                SalePrice = model.SalePrice,
                Amount = model.Amount,
                Guarantee = model.Guarantee,
                Country = model.Country,
                Kit = model.Kit,
                Size = model.Size,
                Weight = model.Weight,
                CategoryId = model.CategoryId,
            };

            await _dataManager.Products.SaveProductAsync(product);

            return product;
        }
    }
}
