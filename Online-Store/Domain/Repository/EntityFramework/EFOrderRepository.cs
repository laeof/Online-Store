using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain.Repository.EntityFramework
{
	public class EFOrderRepository: IOrderRepository
	{
		private readonly AppDbContext context;
		public EFOrderRepository(AppDbContext context)
		{
			this.context = context;
		}
		public IQueryable<Order> GetOrders()
		{
			return context.Orders;
		}
		public async Task<Order> GetOrderByIdAsync(Guid id)
		{
			return await context.Orders.FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task<bool> SaveOrderAsync(Order entity)
		{
            if (entity.IsNew)
            {
				context.Entry(entity).State = EntityState.Added;
				entity.IsNew = false;
			}
			else
				context.Entry(entity).State = EntityState.Modified;

			var saveTask = context.SaveChangesAsync();

			await saveTask;

			return saveTask.IsCompletedSuccessfully;
		}
		public async Task<bool> SoftDeleteOrderAsync(Order entity)
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
