using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;
using System.Data.Common;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFCartItemsRepository: ICartItemsRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<EFCartItemsRepository> logger;
        public EFCartItemsRepository(AppDbContext context, ILogger<EFCartItemsRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public IQueryable<CartItems> GetCartItems()
        {
            return context.CartItems.Where(c => !c.IsDeleted);
        }
        public async Task<CartItems?> GetCartItemByIdAsync(Guid id)
        {
            return await context.CartItems.Where(c => c.Id == id).FirstOrDefaultAsync();
        }
        public async Task<bool> SaveCartItemAsync(CartItems entity)
        {
            if (entity.IsNew)
            {
                logger.LogInformation($"Creating a cartItem. cartItemId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Added;
                entity.IsNew = false;
            }
            else
            {
                logger.LogInformation($"Editing a cartItem. cartItemId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Modified;
            }
            try
            {
                await context.SaveChangesAsync();
                logger.LogInformation($"Saving a cartItem. cartItemId: {entity.Id}.");
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.LogError($"Error to save a cartItem. cartItemId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbUpdateException ex)
            {
                logger.LogError($"Error to save a cartItem. cartItemId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbException ex)
            {
                logger.LogError($"Error to save a cartItem. cartItemId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> DeleteCartItemAsync(CartItems entity)
        {
            var cartItem = await context.Users.FirstOrDefaultAsync(r => r.Id == entity.Id);
            if (cartItem != null)
            {
                context.Remove(cartItem);

                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }
    }
}
