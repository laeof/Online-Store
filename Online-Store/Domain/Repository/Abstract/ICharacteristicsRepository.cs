using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;

namespace Online_Store.Domain.Repository.Abstract
{
    public interface ICharacteristicsRepository
    {
        IQueryable<Characteristics> GetCharacteristics();
        Task<Characteristics?> GetCharacteristicsByIdAsync(Guid id);
        Task<bool> SaveCharacteristicsAsync(Characteristics entity);
        Task<bool> SoftDeleteCharacteristicsAsync(Characteristics entity);
    }
}
