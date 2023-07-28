namespace Online_Store.Domain.Entities
{
	public class Role
	{
		public Guid Id { get; set; }
		public Role()
		{
			Id = Guid.NewGuid();
		}
		public string? Name { get; set; }
		public ICollection<UserRole>? UserRoles { get; set; }
	}
}
