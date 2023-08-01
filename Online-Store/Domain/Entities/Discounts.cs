namespace Online_Store.Domain.Entities
{
    public class Discounts : AbstractModel
    {
        public string Name { get; set; }
        public int Percent { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }
}
