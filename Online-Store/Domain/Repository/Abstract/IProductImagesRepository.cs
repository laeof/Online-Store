using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;

namespace Online_Store.Domain.Repository.Abstract
{
    public interface IProductImagesRepository
    {
        IQueryable<ProductImages> GetProductImages();
        IQueryable<ProductImages> GetProductImagesById(Guid id);
        Task<bool> SaveProductImagesAsync(ProductImages entity);
        Task<bool> SoftDeleteProductImagesAsync(ProductImages entity);
    }
}
