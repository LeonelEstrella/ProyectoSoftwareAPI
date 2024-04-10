using Application.Interface;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Queries
{
    public class ProductQuery : IProductQuery
    {
        private readonly AppDbContext _context;
        public ProductQuery(AppDbContext context)
        {
            _context = context;
        }
        public Product GetProductById(Guid productId)
        {
            return _context.Product.FirstOrDefault(p => p.ProductId == productId);
        }

        public List<Product> GetProductList()
        {
            throw new NotImplementedException();
        }
    }
}
