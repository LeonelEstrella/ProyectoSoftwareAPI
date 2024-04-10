using Aplication.Interface;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Command
{
    public class ProductCommand : IProductCommand
    {
        private readonly AppDbContext _context;

        public ProductCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertProduct(Product product) 
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public Task RemoveProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
