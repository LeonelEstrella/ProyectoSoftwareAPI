using Application.Interface.SaleInterface;
using Application.Response;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Command
{
    public class SaleCommand : ISaleCommand
    {
        const decimal TAXES = 1.21m;

        private readonly AppDbContext _context;

        public SaleCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> RegisterSale(IList<SaleProductResponse> productList, Sale sale)
        {
            var newSale = new Sale
            {
                TotalPay = sale.TotalPay,
                Subtotal = sale.Subtotal,
                TotalDiscount = sale.TotalDiscount,
                Taxes = TAXES,
                Date = DateTime.Now,
            };

            newSale.SaleProduct = new List<SaleProduct>();

            foreach (var singleProduct in productList)
            { 
                var saleProduct = new SaleProduct
                {
                    Product = singleProduct.id,
                    Quantity = singleProduct.quantity,
                    Price = singleProduct.price,
                    Discount = singleProduct.discount
                };

                newSale.SaleProduct.Add(saleProduct);       
            }

            _context.Sale.Add(newSale);
            _context.SaveChanges();

            return newSale.SaleId;
        }
    }
}
