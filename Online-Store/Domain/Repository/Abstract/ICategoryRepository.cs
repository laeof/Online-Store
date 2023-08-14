using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories();
        Task<Category> GetCategoryByIdAsync(Guid id);
        Task<bool> SaveCategoryAsync(Category entity);
        Task<bool> SoftDeleteCategoryAsync(Category entity);
    }
}
