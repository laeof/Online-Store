using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
	public interface IOrdersRepository
	{
		IQueryable<Orders> GetOrders();
		Task<Orders> GetOrderByIdAsync(Guid id);
		Task<bool> SaveOrderAsync(Orders entity);
		Task<bool> DeleteOrderAsync(Guid id);
		Task<bool> SoftDeleteOrderAsync(Orders entity);
	}
}
