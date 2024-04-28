using Application.Interface.SaleInterface;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Queries
{
    public class SaleQuery : ISaleQuery
    {
        private readonly AppDbContext _context;

        public SaleQuery(AppDbContext context)
        {
            _context = context;
        }

        public Sale GetSaleById(int saleId)
        {
            return _context.Sale.FirstOrDefault(s => s.SaleId == saleId);
        }

        public List<Sale> GetSales(DateTime? fromDate, DateTime? toDate)
        {
            IQueryable<Sale> query = _context.Sale;

            if (fromDate.HasValue)
            {
                query = query.Where(s => s.DateTime >= fromDate);
            }

            if (toDate.HasValue)
            {
                query = query.Where(s => s.DateTime <= toDate);
            }
            
            return query.ToList();
        }
    }
}
