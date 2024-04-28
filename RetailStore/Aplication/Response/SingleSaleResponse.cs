namespace Application.Response
{
    public class SingleSaleResponse
    {
        public int id {  get; set; }
        public double totalPay { get; set;}
        public int totalQuantity { get; set; }
        public decimal totalDiscount { get; set; }
        public double subtotal {  get; set; }
        public double taxes { get; set; }
        public DateTime date { get; set; }
        public List<SingleSaleProduct> products { get; set; }
    }

    public class SingleSaleProduct 
    {
        public Guid productId { get; set;}
        public int quantity {  get; set; }
        public double price { get; set; }
        public int discount {  get; set; }

    }
}
