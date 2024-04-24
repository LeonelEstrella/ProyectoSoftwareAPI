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
            DateTime fromDate = DateTime.Parse(from);
            DateTime toDate = DateTime.Parse(to);
            return _context.Sale.ToList(/*s => s.DateTime >= fromDate && s.DateTime <= toDate*/);
        }
    }
}
