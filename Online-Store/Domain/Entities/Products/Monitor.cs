using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities.Products
{
    public class Monitor: AbstractModel
    {
        public string Diagonal { get; set; }
        public string Frequency { get; set; }
        public string Reaction { get; set; }
        public string Brightness { get; set; }
        public string MatrixType { get; set; }
        public string Interfaces { get; set; }
        public string Contrast { get; set; }
        public string Ratio { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
