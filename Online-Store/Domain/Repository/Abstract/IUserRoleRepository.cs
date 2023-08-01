using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
	public interface IUserRoleRepository
	{
		IQueryable<UserRole> GetUserRole();
		Task<UserRole> GetUserRoleByIdAsync(Guid id);
		Task<bool> SaveUserRoleAsync(UserRole entity);
	}
}
