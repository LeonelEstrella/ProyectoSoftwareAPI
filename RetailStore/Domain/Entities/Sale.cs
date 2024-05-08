using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleId { get; set; }

        [Required]
        public decimal TotalPay { get; set; }

        [Required]
        public decimal Subtotal { get; set; }

        [Required]
        public decimal TotalDiscount { get; set; }

        [Required]
        public decimal Taxes { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public ICollection<SaleProduct> SaleProduct { get; set; }
    }
}
