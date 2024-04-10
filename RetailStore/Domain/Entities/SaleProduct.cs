using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class SaleProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleProductId { get; set; }
        public Guid ProductId {  get; set; } 
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
