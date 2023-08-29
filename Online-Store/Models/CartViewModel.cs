using Online_Store.Domain.Entities;

namespace Online_Store.Models
{
    public class CartViewModel
    {
        public Guid? ProductId { get; set; }
        public Guid? UserId { get; set; }
        public List<CartItems>? CartItems { get; set; }
        public CartItems? CartItem { get; set; }
    }
}
