using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain.Repository.EntityFramework
{
	public class EFOrdersRepository: IOrdersRepository
	{
		private readonly AppDbContext context;
		public EFOrdersRepository(AppDbContext context)
		{
			this.context = context;
		}
		public IQueryable<Orders> GetOrders()
		{
			return context.Orders;
		}
		public async Task<Orders> GetOrderByIdAsync(Guid id)
		{
			return await context.Orders.FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task<bool> SaveOrderAsync(Orders entity)
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
		public async Task<bool> DeleteOrderAsync(Guid id)
		{
			context.Orders.Remove(new Orders { Id = id });

			var saveTask = context.SaveChangesAsync();

			await saveTask;

			return saveTask.IsCompletedSuccessfully;
		}
		public async Task<bool> SoftDeleteOrderAsync(Orders entity)
		{
			var order = await context.Users.FirstOrDefaultAsync(r => r.Id == entity.Id);
			if (order != null)
			{
				order.IsDeleted = true;

				await context.SaveChangesAsync();

				return true;
			}
			return false;
		}
	}
}
