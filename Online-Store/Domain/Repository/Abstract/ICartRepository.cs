using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
    public interface ICartRepository
    {
        IQueryable<Cart> GetCarts();
        Task<Cart> GetCartByIdAsync(Guid id);
        Task<bool> SaveCartAsync(Cart entity);
        Task<bool> ClearCartAsync(Cart entity);
    }
}
