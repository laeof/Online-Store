using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using Online_Store.Domain.Repository.Abstract;
using System.Data.Common;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFCharacteristicsRepository: ICharacteristicsRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<EFCharacteristicsRepository> logger;
        public EFCharacteristicsRepository(AppDbContext context, ILogger<EFCharacteristicsRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public IQueryable<Characteristics> GetCharacteristics()
        {
            return context.Characteristics.Where(c => !c.IsDeleted);
        }
        public async Task<Characteristics?> GetCharacteristicsByIdAsync(Guid id)
        {
            return await context.Characteristics.Where(c => c.Id == id).Include(c => c.Products).FirstOrDefaultAsync();
        }
        public async Task<bool> SaveCharacteristicsAsync(Characteristics entity)
        {
            if (entity.IsNew)
            {
                logger.LogInformation($"Creating a characteristic. CharacteristicsId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Added;
                entity.IsNew = false;
            }
            else
            {
                logger.LogInformation($"Editing a characteristic. CharacteristicsId: {entity.Id}.");
                context.Entry(entity).State = EntityState.Modified;
            }
            try
            {
                await context.SaveChangesAsync();
                logger.LogInformation($"Saving a characteristics. characteristicsId: {entity.Id}.");
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.LogError($"Error to save a characteristic. CharacteristicsId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbUpdateException ex)
            {
                logger.LogError($"Error to save a characteristic. CharacteristicsId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
            catch (DbException ex)
            {
                logger.LogError($"Error to save a characteristic. CharacteristicsId: {entity.Id}. Message: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> SoftDeleteCharacteristicsAsync(Characteristics entity)
        {
            var characteristic = await context.Characteristics.FirstOrDefaultAsync(r => r.Id == entity.Id);
            if (characteristic != null)
            {
                characteristic.IsDeleted = true;

                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }
    }
}
