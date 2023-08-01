using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain.Repository.EntityFramework
{
	public class EFRoleRepository: IRoleRepository
	{
		private readonly AppDbContext context;
		public EFRoleRepository(AppDbContext context)
		{
			this.context = context;
		}
		public IQueryable<Role> GetRole()
		{
			return context.Roles;
		}
        public async Task<Role> GetRoleByIdAsync(Guid id)
        {
            return await context.Roles.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Role> GetRoleByNameAsync(string name)
		{
			return await context.Roles.FirstOrDefaultAsync(x => x.Name == name);
		}
		public async Task<bool> SaveRoleAsync(Role entity)
		{
			if (entity.Id == default)
			{
				context.Entry(entity).State = EntityState.Added;
			}
			else
				context.Entry(entity).State = EntityState.Modified;

			var saveTask = context.SaveChangesAsync();

			await saveTask;

			return saveTask.IsCompletedSuccessfully;
		}
		public async Task<bool> SoftDeleteRoleAsync(Role entity)
		{
			var role = await context.Users.FirstOrDefaultAsync(r => r.Id == entity.Id);
			if (role != null)
			{
				role.IsDeleted = true;

				await context.SaveChangesAsync();

				return true;
			}
			return false;
		}
	}
}
