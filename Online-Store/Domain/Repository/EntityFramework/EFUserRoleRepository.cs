using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;
using System.Data.Common;

namespace Online_Store.Domain.Repository.EntityFramework
{
	public class EFUserRoleRepository: IUserRoleRepository
	{
		private readonly AppDbContext context;
        private readonly ILogger<EFUserRepository> logger;
        public EFUserRoleRepository(AppDbContext context, ILogger<EFUserRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public IQueryable<UserRole> GetUserRole()
		{
			return context.UserRoles.AsNoTracking();
		}
		public async Task<UserRole> GetUserRoleByIdAsync(Guid id)
		{
			return await context.UserRoles.FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task<bool> SaveUserRoleAsync(UserRole entity)
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
                context.Entry(entity).State = EntityState.Modified;
            }
            try
            {
                await context.SaveChangesAsync();
                logger.LogInformation($"Saving a user. UserRoleId: {entity.Id}.");
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.LogError($"Error to save a user. UserRoleId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbUpdateException ex)
            {
                logger.LogError($"Error to save a user. UserRoleId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbException ex)
            {
                logger.LogError($"Error to save a user. UserRoleId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
        }
	}
}
