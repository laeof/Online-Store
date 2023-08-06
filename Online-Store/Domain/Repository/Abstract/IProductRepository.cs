using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
        Task<Product> GetProductByIdAsync(Guid id);
        Task<bool> SaveProductAsync(Product entity);
        Task<bool> SoftDeleteProductAsync(Product entity);
    }
}
