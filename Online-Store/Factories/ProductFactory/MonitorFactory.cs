using Online_Store.Domain.Entities.Products;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Models;

namespace Factories
{
    public class MonitorFactory: ProductFactory<Online_Store.Domain.Entities.Products.Monitor>
    {
        private DataManager _dataManager { get; set; }
        public MonitorFactory(DataManager dataManager): base(dataManager)
        {
            _dataManager = dataManager;
        }

        public override async Task<Product> CreateProduct(ProductViewModel model)
        {
            var product = new Online_Store.Domain.Entities.Products.Monitor
            {
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
