using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain.Repository.EntityFramework
{
	public class EFUserRepository: IUserRepository
	{
		private readonly AppDbContext context;
		public EFUserRepository(AppDbContext context)
		{
			this.context = context;
		}
		public IQueryable<User> GetUsers() 
		{
			return context.Users.Where(x => x.IsDeleted != true);
		}
		public async Task<User> GetUserByIdAsync(Guid id)
		{
			return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task<bool> SaveUserAsync(User entity)
		{
			if (entity.Id == default)
			{
				context.Entry(entity).State = EntityState.Added;
			}
			else
			{
				if (entity.Password != null)
				{
					context.Entry(entity).Property(u => u.Password).IsModified = true;
				}
			}
			var saveTask = context.SaveChangesAsync();

			await saveTask;

			return saveTask.IsCompletedSuccessfully;
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
