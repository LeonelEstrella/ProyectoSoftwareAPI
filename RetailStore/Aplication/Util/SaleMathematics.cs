using Application.Interface.SaleMathsInterfaces;
using Application.Response;
using Domain.Entities;

namespace Application.Util
{
    public class SaleMathematics : ISaleMathematics
    {

        private Sale _sale;
        const decimal TAXES = 1.21m;

        public SaleMathematics(Sale sale)
        {
            _sale = sale;
        }

        public Sale CalculateSale(IList<AllSaleInformation> productList)
        {
            
            foreach (var product in productList)
            {
                decimal auxSubTotal = 0;
                decimal auxTotalDiscount = 0;

                auxSubTotal +=  (product.price * product.quantity);

                _sale.Subtotal += auxSubTotal;

                if (product.discount != 0) 
                {
                    decimal discount = product.discount ?? 0;
                    auxTotalDiscount += (product.price - (product.price * (1 - (discount / 100M)))) * product.quantity;
                    _sale.TotalDiscount += auxTotalDiscount;
                }

                _sale.TotalPay += (auxSubTotal - auxTotalDiscount) * TAXES;
            }

            return _sale;
        }
    }
}
