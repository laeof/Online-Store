using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
	public interface IOrderRepository
	{
		IQueryable<Order> GetOrders();
		Task<Order> GetOrderByIdAsync(Guid id);
		Task<bool> SaveOrderAsync(Order entity);
		Task<bool> SoftDeleteOrderAsync(Order entity);
	}
}
