namespace Application.Response
{
    public class ProductListResponse
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal? discount { get; set; }
        public string? imageUrl { get; set; }
        public string categoryName { get; set; }
    }
}
