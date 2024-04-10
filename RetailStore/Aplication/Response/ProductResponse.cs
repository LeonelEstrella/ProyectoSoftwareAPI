namespace Aplication.Response
{
    public class ProductResponse
    {
        public Guid ProductId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public string CategoryName { get; set; }
        public string ImageLink { get; set; }
    }
}
