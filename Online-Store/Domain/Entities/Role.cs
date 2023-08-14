namespace Online_Store.Domain.Entities
{
	public class Role: AbstractModel
	{
		public string Name { get; set; }
		public int Priority { get; set; }
		public ICollection<User> Users { get; set; }
	}
}
