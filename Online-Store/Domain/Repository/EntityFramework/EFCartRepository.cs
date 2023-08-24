using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using Online_Store.Domain.Repository.Abstract;
using System.Data.Common;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFCartRepository : ICartRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<EFCartRepository> logger;
        public EFCartRepository(AppDbContext context, ILogger<EFCartRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public IQueryable<Cart> GetCarts()
        {
            return context.Carts.Where(c => !c.IsDeleted);
        }
        public async Task<Cart?> GetCartByIdAsync(Guid id)
        {
            return await context.Carts.Where(c => c.Id == id).Include(c => c.CartItems).FirstOrDefaultAsync();
        }
        public async Task<bool> SaveCartAsync(Cart entity)
        {
            if (entity.IsNew)
            {
                logger.LogInformation($"Creating a cart. CartId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Added;
                entity.IsNew = false;
            }
            else
            {
                logger.LogInformation($"Editing a cart. CartId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Modified;
            }
            try
            {
                await context.SaveChangesAsync();
                logger.LogInformation($"Saving a cart. CartId: {entity.Id}.");
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.LogError($"Error to save a cart. CartId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbUpdateException ex)
            {
                logger.LogError($"Error to save a cart. CartId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbException ex)
            {
                logger.LogError($"Error to save a cart. CartId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> ClearCartAsync(Cart entity)
        {
            return false;
        }
    }
}
