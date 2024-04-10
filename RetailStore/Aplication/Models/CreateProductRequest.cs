namespace Aplication.Models
{
    public class CreateProductRequest
    {
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductDiscount { get; set; }
        public int CategoryCategoryId { get; set; }
        public string ProductImageLink { get; set; }
    }
}
