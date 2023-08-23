using Online_Store.Domain.Entities.Products;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Models;

namespace Online_Store
{
    public class MonitorFactory: IProductFactory
    {
        private DataManager _dataManager { get; set; }
        public MonitorFactory(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public async Task<Product> CreateProduct(ProductViewModel model)
        {
            var product = new Domain.Entities.Products.Monitor
            {
                Name = model.Name,
                Price = model.Price,
                Amount = model.Amount,
                Description = model.Description,
                Diagonal = model.Monitor.Diagonal,
                Brightness = model.Monitor.Brightness,
                CategoryId = model.CategoryId,
                MatrixType = model.Monitor.MatrixType,
                Ratio = model.Monitor.Ratio,
                Reaction = model.Monitor.Reaction,
                Frequency = model.Monitor.Frequency,
                Interfaces = model.Monitor.Interfaces,
                Contrast = model.Monitor.Contrast,
            };

            await _dataManager.Products.SaveProductAsync(product);

            return product;
        }
    }
}
