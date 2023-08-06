using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFProductRepository: IProductRepository
    {
        private readonly AppDbContext context;
        public EFProductRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Product> GetProducts()
        {
            return context.Products;
        }
        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<bool> SaveProductAsync(Product entity)
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
        public async Task<bool> SoftDeleteProductAsync(Product entity)
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
