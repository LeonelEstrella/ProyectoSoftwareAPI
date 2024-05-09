using Application.Interface.SaleInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Queries
{
    public class SaleQuery : ISaleQuery
    {
        private readonly AppDbContext _context;

        public SaleQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Sale> GetSaleById(int saleId)
        {
            return await _context.Sale.FirstOrDefaultAsync(s => s.SaleId == saleId);
        }

        public List<Sale> GetSales(DateTime? fromDate, DateTime? toDate)
        {
            IQueryable<Sale> query = _context.Sale;

            if (fromDate.HasValue)
            {
                query = query.Where(s => s.Date > fromDate);
            }

            if (toDate.HasValue)
            {
                query = query.Where(s => s.Date < toDate);
            }
            
            return query.ToList();
        }
    }
}
