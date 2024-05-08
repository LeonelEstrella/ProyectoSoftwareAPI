using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }
        public int? Discount { get; set; }

        [Required]
        public int Category { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey("Category")]
        public Category category { get; set; }
        public ICollection<SaleProduct> SaleProduct { get; set; }
    }
}
