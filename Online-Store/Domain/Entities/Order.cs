using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
	public class Order: AbstractModel
	{
		public Guid UserId { get; set; }
		[ForeignKey("UserId")]
		public User User { get; set; }
		public DateTime Created { get; set; }
		public OrderStatus Status { get; set; }
		public enum OrderStatus
		{
			Pending = 1,
			Sent = 2,
			Delivered = 3
		}
	}
}
