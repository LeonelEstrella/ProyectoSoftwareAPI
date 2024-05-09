using Application.Interface.SaleInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Command
{
    public class SaleCommand : ISaleCommand
    {

        private readonly AppDbContext _context;

        public SaleCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> RegisterSale(Sale sale)
        {
            _context.Sale.Add(sale);
            _context.SaveChanges();

            return sale.SaleId;
        }
    }
}
