using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
    public interface ICartItemsRepository
    {
        IQueryable<CartItems> GetCartItems();
        Task<CartItems> GetCartItemByIdAsync(Guid id);
        Task<bool> SaveCartItemAsync(CartItems entity);
        Task<bool> DeleteCartItemAsync(CartItems entity);
    }
}