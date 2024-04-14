using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NuGet.Packaging;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using Online_Store.Domain.Repository.Abstract;
using System.Data.Common;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFCategoryRepository : ICategoryRepository
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
            return context.Categories.Where(c => !c.IsDeleted);
        }
        public async Task<Category?> GetCategoryByIdAsync(Guid id)
        {
            var category = await context.Categories
                            .Where(c => c.Id == id)
                            .FirstOrDefaultAsync();

            if (category == null)
                return category;

            category.Categories = await context.Categories
                                        .Where(c => c.CategoryParentId == category.Id)
                                        .Select(c => new Category
                                        {
                                            Id = c.Id,
                                            Name = c.Name,
                                            CategoryParentId = c.CategoryParentId,
                                            ImgPath = c.ImgPath,
                                        })
                                        .ToListAsync();

            var allNestedCategoryIds = category.Categories.Select(c => c.Id).ToList();

            var allNestedProducts = await context.Products
                                        .Where(p => p.CategoryId == id || allNestedCategoryIds.Contains(p.CategoryId))
                                        .Include(c => c.Images)
                                        .Select(c => new Product
                                        {
                                            Id = c.Id,
                                            Additional = c.Additional,
                                            Amount = c.Amount,
                                            CategoryId = c.CategoryId,
                                            Characteristics = c.Characteristics,
                                            Price = c.Price,
                                            Name = c.Name,
                                            Weight = c.Weight,
                                        })
                                        .ToListAsync();

            category.Products.AddRange(allNestedProducts);

            return category;
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
            var category = await context.Characteristics.FirstOrDefaultAsync(r => r.Id == entity.Id);
            
            if (category != null)
                return false;

            category.IsDeleted = true;

            await context.SaveChangesAsync();

            return true;
        }
    }
}
