using Application.Interface.SaleMaths;
using Application.Response;
using Domain.Entities;

namespace Application.Util
{
    public class SaleMathematics : ISaleMathematics
    {
        const decimal TAXES = 1.21m;

        public Sale CalculateSale(IList<ProductGetResponse> productList, Sale saleInformation)
        {
            
            foreach (ProductGetResponse product in productList)
            {
                decimal auxSubTotal = 0;
                decimal auxTotalDiscount = 0;

                auxSubTotal +=  (product.price * product.quantity.Value);

                saleInformation.Subtotal += auxSubTotal;

                if (product.discount != 0) 
                {
                    auxTotalDiscount += (product.price - (product.price * (1 - (product.discount / 100M)))) * product.quantity.Value;
                    saleInformation.TotalDiscount += auxTotalDiscount;
                }

                saleInformation.TotalPay += (auxSubTotal - auxTotalDiscount) * TAXES;
            }

            return saleInformation;
        }
    }
}
