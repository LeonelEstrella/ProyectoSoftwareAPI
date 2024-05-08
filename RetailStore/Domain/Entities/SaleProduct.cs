using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class SaleProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShoppingCartId { get; set; }

        [Required]
        public int Sale { get; set; }

        [Required]
        public Guid Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
        public int? Discount { get; set; }

        [ForeignKey("Product")]
        public Product product { get; set; }

        [ForeignKey("Sale")]
        public Sale sale { get; set; }
    }
}
