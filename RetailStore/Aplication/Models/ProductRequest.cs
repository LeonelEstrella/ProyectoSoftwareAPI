namespace Application.Models
{
    public class ProductRequest
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public double price { get; set; }
        public int discount { get; set; }
        public string? imageUrl { get; set; }
        public int category { get; set; }
    }
}
