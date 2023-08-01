namespace Online_Store.Domain.Entities
{
    public abstract class AbstractModel
    {
        public Guid Id { get; protected set; }
        public AbstractModel()
        {
            Id = Guid.NewGuid();
        }

    }
}
