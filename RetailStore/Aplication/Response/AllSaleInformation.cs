namespace Application.Response
{
    public class AllSaleInformation
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int? discount { get; set; }
        public string imageUrl { get; set; }
        public int quantity { get; set; }
        public decimal totalPay { get; set; }
        public int totalQuantity { get; set; }
        public decimal subtotal { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal taxes { get; set; }
        public DateTime date { get; set; }
        public List<AllSaleInformationSingleSaleProduct> products { get; set; }
        public AllSaleInformationCategoryResponse category { get; set; }

        public class AllSaleInformationCategoryResponse
        {
            public int id { get; set; }
            public string? name { get; set; }
        }

        public class AllSaleInformationSingleSaleProduct
        {
            public int id { get; set; }
            public Guid productId { get; set; }
            public int quantity { get; set; }
            public decimal price { get; set; }
            public int? discount { get; set; }

        }
    }
}
