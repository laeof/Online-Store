using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
	public class UserRole: AbstractModel
	{
		public Guid RoleId { get; set; }
		[ForeignKey("RoleId")]
		public Role? Role { get; set; }
		public Guid UserId { get; set; }
		[ForeignKey("UserId")]
		public User? User { get; set; }
	}
}
