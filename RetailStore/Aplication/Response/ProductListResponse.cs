namespace Application.Response
{
    public class ProductListResponse
    {
        public Guid id { get; set; }
        public required string name { get; set; }
        public decimal price { get; set; }
        public int discount { get; set; }
        public string imageUrl { get; set; }
        public string categoryName { get; set; }
    }
}
