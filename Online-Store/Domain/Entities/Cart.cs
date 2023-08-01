namespace Online_Store.Domain.Entities
{
    public class Cart:AbstractModel
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
