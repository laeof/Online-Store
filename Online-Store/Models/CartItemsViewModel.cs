namespace Online_Store.Models
{
    public class CartItemsViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid CartId { get; set; }
        public int ProductAmount { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
