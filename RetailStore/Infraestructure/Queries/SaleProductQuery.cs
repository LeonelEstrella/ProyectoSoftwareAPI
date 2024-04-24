using Application.Interface.SaleProductInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Queries
{
    public class SaleProductQuery : ISaleProductQuery
    {
        private readonly AppDbContext _context;

        public SaleProductQuery(AppDbContext context)
        {
            _context = context;
        }

        public List<SaleProduct> GetSaleProductById(int saleId)
        {
            return _context.SaleProduct.Where(sp => sp.SaleId == saleId).ToList();
        }

        public bool ProductExistInSale(Guid productId)
        {
            return _context.SaleProduct.Where(sp => sp.ProductId == productId).Any();
        }
    }
}
