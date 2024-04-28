namespace Application.Response
{
    public class ProductGetResponse
    {
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public decimal price { get; set; }
        public int discount { get; set; }
        public string? imageUrl { get; set; }
        public int? quantity { get; set; }
        public ProductCategoryResponse category { get; set; }       
    }

    public class ProductCategoryResponse 
    {
        public int id { get; set; }
        public string? name { get; set; }
    }
}
