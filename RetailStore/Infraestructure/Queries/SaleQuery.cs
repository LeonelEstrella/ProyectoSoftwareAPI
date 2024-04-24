using Application.Interface.SaleInterface;
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

        public Sale GetSaleById(int saleId)
        {
            return _context.Sale.FirstOrDefault(s => s.SaleId == saleId);
        }

        public List<Sale> GetSales(string from, string to)
        {
            IQueryable<Sale> query = _context.Sale;

            if (!string.IsNullOrEmpty(from))
            {
                DateTime fromDate = DateTime.Parse(from);
                query = query.Where(s => s.DateTime >= fromDate);
            }

            if (!string.IsNullOrEmpty(to))
            {
                DateTime toDate = DateTime.Parse(to);
                query = query.Where(s => s.DateTime <= toDate);
            }
            
            return query.ToList();
        }
    }
}
