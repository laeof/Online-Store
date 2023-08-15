namespace Online_Store.Domain.Entities
{
    public abstract class AbstractModel
    {
        public AbstractModel()
        {
            Id = Guid.NewGuid();
            Created = DateTime.UtcNow;
        }
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public bool IsNew { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
