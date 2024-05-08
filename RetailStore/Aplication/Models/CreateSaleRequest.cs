namespace Application.Models
{
    public class CreateSaleRequest
    {
        public List<CreateSaleProducts>? products { get; set; }
        public decimal totalPayed { get; set; }
    }

    public class CreateSaleProducts
    {
        public Guid productId { get; set; }
        public int quantity { get; set; }
    }
}
