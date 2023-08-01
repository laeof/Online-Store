namespace Online_Store.Domain.Entities
{
	public class Role: AbstractModel
	{
		public string? Name { get; set; }
		public ICollection<UserRole>? UserRoles { get; set; }
	}
}
