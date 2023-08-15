using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using Online_Store.Domain.Repository.Abstract;
using System.Data.Common;
using Monitor = Online_Store.Domain.Entities.Products.Monitor;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFCategoryRepository: ICategoryRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<EFCategoryRepository> logger;
        public EFCategoryRepository(AppDbContext context, ILogger<EFCategoryRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public IQueryable<Category> GetCategories()
        {
            return context.Categories.Include(x => x.Products).Where(c => !c.IsDeleted);
        }
        public async Task<Category?> GetCategoryByIdAsync(Guid id)
        {
            return await context.Categories.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<bool> SaveCategoryAsync(Category entity)
        {
            if (entity.IsNew)
            {
                logger.LogInformation($"Creating a category. CategoryId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Added;
                entity.IsNew = false;
            }
            else
            {
                logger.LogInformation($"Editing a category. CategoryId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Modified;
            }
            try
            {
                await context.SaveChangesAsync();
                logger.LogInformation($"Saving a category. CategoryId: {entity.Id}.");
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.LogError($"Error to save a category. CategoryId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbUpdateException ex)
            {
                logger.LogError($"Error to save a category. CategoryId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbException ex)
            {
                logger.LogError($"Error to save a category. CategoryId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> SoftDeleteCategoryAsync(Category entity)
        {
            var category = await context.Users.FirstOrDefaultAsync(r => r.Id == entity.Id);
            if (category != null)
            {
                category.IsDeleted = true;

                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }
    }
}
