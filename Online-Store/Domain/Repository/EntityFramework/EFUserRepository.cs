using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;
using System.Data.Common;

namespace Online_Store.Domain.Repository.EntityFramework
{
	public class EFUserRepository: IUserRepository
	{
		private readonly AppDbContext context;
        private readonly ILogger<EFUserRepository> logger;
        public EFUserRepository(AppDbContext context, ILogger<EFUserRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public IQueryable<User> GetUsers() 
		{
            return context.Users.Where(x => x.IsDeleted != true);
		}
		public async Task<User?> GetUserByIdAsync(Guid id)
		{
			return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
		}
        public async Task<User?> GetUserByGoogleIdAsync(string googleId) {
            return await context.Users.FirstOrDefaultAsync(x => x.GoogleId == googleId);
        }
		public async Task<bool> SaveUserAsync(User entity)
		{
            if (entity.IsNew)
            {
                logger.LogInformation($"Creating a user. UserId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Added;
                entity.IsNew = false;
			}
			else
            {
                logger.LogInformation($"Editing a user. UserId: {entity.Id}.");
                if (entity.Password != null)
				{
					context.Entry(entity).Property(u => u.Password).IsModified = true;
				}
			}
            try
            {
                await context.SaveChangesAsync();
                logger.LogInformation($"Saving a user. UserId: {entity.Id}.");
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.LogError($"Error to save a user. UserId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbUpdateException ex)
            {
                logger.LogError($"Error to save a user. UserId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbException ex)
            {
                logger.LogError($"Error to save a user. UserId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
        }
		public async Task<bool> SoftDeleteUserAsync(User user)
		{
			var usr = await context.Users.FirstOrDefaultAsync(r => r.Id == user.Id);
			if (usr != null)
			{
				usr.IsDeleted = true;

				await context.SaveChangesAsync();

				return true;
			}
			return false;
		}
	}
}
