namespace Online_Store.Domain.Entities
{
    public class Product: AbstractModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public int? Amount { get; set;}
    }
}
