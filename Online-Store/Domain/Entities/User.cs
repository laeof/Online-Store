namespace Online_Store.Domain.Entities
{
	public class User: AbstractModel
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PhoneNumber { get; set; }
		public string? Address { get; set; }
		public string? City { get; set; }
		public string? Region { get; set; }
		public string? PostalCode { get; set; }
		public string? Country { get; set; }
		public string AvatarUrl { get; set; } = "../../../../img/Avatar/user.png";
		public string? ApiKey { get; set; }
		public bool? Gender { get; set; }
		public bool IsEmailConfirmed { get; set; } = false;
		public bool IsActive { get; set; } = true;
		public ICollection<Order>? Order { get; set; }
		public ICollection<UserRole>? UserRoles { get; set; }
	}
}
