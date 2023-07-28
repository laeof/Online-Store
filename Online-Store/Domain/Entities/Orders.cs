using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
	public class Orders
	{
		public Guid Id { get; set; }
		public Orders()
		{
			Id = Guid.NewGuid();
		}
		public string? Name { get; set; }
		public string? Description { get; set; }
		public DateTime? CreatedDate { get; set; }
		public Guid UserId { get; set; }
		[ForeignKey("UserId")]
		public User User { get; set; }
	}
}
