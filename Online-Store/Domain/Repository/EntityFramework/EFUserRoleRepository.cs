using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain.Repository.EntityFramework
{
	public class EFUserRoleRepository: IUserRoleRepository
	{
		private readonly AppDbContext context;
		public EFUserRoleRepository(AppDbContext context)
		{
			this.context = context;
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
			if (entity.Id == default)
			{
				context.Entry(entity).State = EntityState.Added;
			}
			else
			{
				context.Entry(entity).State = EntityState.Modified;
			}
			var saveTask = context.SaveChangesAsync();

			await saveTask;

			return saveTask.IsCompletedSuccessfully;
		}
	}
}
