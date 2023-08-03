using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
	public interface IRoleRepository
	{
		IQueryable<Role> GetRole();
        Task<Role> GetRoleByIdAsync(Guid id);
        Task<Role> GetRoleByPriorityAsync(int priority);
		Task<bool> SaveRoleAsync(Role entity);
		Task<bool> SoftDeleteRoleAsync(Role entity);
	}
}
