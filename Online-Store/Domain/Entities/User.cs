using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
	public class User: AbstractModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PhoneNumber { get; set; }
		public string? Address { get; set; }
		public string? City { get; set; }
		public string? Region { get; set; }
		public string? PostalCode { get; set; }
		public string? Country { get; set; }
		public string AvatarUrl { get; set; } = "../../../../img/Avatar/user.png";
        public string? Gender { get; set; }
        public string? ApiKey { get; set; }
		public Guid RoleId { get; set; }
		public Guid CartId { get; set; }
		public bool IsEmailConfirmed { get; set; } = false;
		public bool IsActive { get; set; } = true;
		public ICollection<Order>? Order { get; set; }
		[ForeignKey("RoleId")]
		public Role Role { get; set; }
		public Cart Cart { get; set; }
	}
}
