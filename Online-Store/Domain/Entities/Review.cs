using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class Review: AbstractModel
    {
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public ReviewGrade Grade { get; set; }
        public enum ReviewGrade
        {
            OneStar = 1,
            TwoStars = 2,
            ThreeStars = 3,
            FourStars = 4,
            FiveStars = 5
        }
    }
}
