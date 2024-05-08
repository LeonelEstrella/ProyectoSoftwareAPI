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

        public async Task<Product> GetProductById(Guid productId)
        {
            return await _context.Product.FirstOrDefaultAsync(p => p.ProductId == productId);
        }

        public async Task<Product> GetProductByName(string name)
        {
            return await _context.Product.FirstOrDefaultAsync(p => p.Name == name);
        }

        public List<Product> GetAllProducts(List<int> categories, string name, int offset, int limit)
        {
            IQueryable<Product> query = _context.Product;

            if (!string.IsNullOrEmpty(name))
            {
                query =  query.Where(p => p.Name.Contains(name));
            }

            if (categories != null && categories.Any())
            {
                query = query.Where(p => categories.Contains(p.Category));
            }

            if (offset > 0)
            {
                query = query.Skip(offset);
            }

            if (limit > 0)
            {
                query = query.Take(limit);
            }

            return query.ToList();
        }

        public async Task<Product> GetProductByNameAndId(string name, Guid productId)
        {
            return await _context.Product.FirstOrDefaultAsync(p => p.Name == name && p.ProductId != productId);
        }
    }
}
