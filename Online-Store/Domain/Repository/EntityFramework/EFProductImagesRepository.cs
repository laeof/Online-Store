using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFProductImagesRepository: IProductImagesRepository
    {
        private readonly AppDbContext context;
        public EFProductImagesRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<ProductImages> GetProductImages()
        {
            return context.ProductImages;
        }
        public async Task<ProductImages> GetProductImagesByIdAsync(Guid id)
        {
            return await context.ProductImages.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<bool> SaveProductImagesAsync(ProductImages entity)
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
        public async Task<bool> SoftDeleteProductImagesAsync(ProductImages entity)
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
