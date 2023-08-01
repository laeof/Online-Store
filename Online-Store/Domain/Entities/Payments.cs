using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class Payments: AbstractModel
    {
        public Guid OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public decimal Price { get; set; }
        public DateTime PayDate { get; set; }
        public enum PayStatus
        {
            Pending,
            Paid,
            Cancelled
        }
    }
}
