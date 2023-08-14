using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
	public interface IUserRepository
	{
		IQueryable<User> GetUsers();
		Task<User?> GetUserByIdAsync(Guid id);
		Task<bool> SaveUserAsync(User entity);
		Task<bool> SoftDeleteUserAsync(User user);
	}
}
