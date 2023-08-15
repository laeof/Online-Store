using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;
using System.Data.Common;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFProductRepository: IProductRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<EFProductRepository> logger;
        public EFProductRepository(AppDbContext context, ILogger<EFProductRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public virtual IQueryable<Product> GetProducts()
        {
            return context.Products;
        }
        public virtual async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<bool> SaveProductAsync(Product entity)
        {
            if (entity.IsNew)
            {
                logger.LogInformation($"Creating a product. ProductId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Added;
                entity.IsNew = false;
            }
            else
            {
                logger.LogInformation($"Editing a product. ProductId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Modified;
            }
            try
            {
                await context.SaveChangesAsync();
                logger.LogInformation($"Saving a product. ProductId: {entity.Id}.");
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.LogError($"Error to save a product. ProductId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbUpdateException ex)
            {
                logger.LogError($"Error to save a product. ProductId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbException ex)
            {
                logger.LogError($"Error to save a product. ProductId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return false;
            }
        }
        public async Task<bool> SoftDeleteProductAsync(Product entity)
        {
            var order = await context.Users.FirstOrDefaultAsync(r => r.Id == entity.Id);
            if (order != null)
            {
                order.IsDeleted = true;

                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }
    }
}
 