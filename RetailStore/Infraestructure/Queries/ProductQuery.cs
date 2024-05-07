using Application.Interface;
using Domain.Entities;
using Infraestructure.Persistence;

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

        public Product GetProductByName(string name)
        {
            return _context.Product.FirstOrDefault(p => p.Name == name);
        }

        public List<Product> GetAllProducts(List<int> categories, string name, int skip, int limit)
        {
            IQueryable<Product> query = _context.Product;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            if (categories != null && categories.Any())
            {
                query = query.Where(p => categories.Contains(p.CategoryId));
            }

            if (skip > 0)
            {
                query = query.Skip(skip);
            }

            if (limit > 0)
            {
                query = query.Take(limit);
            }

            return query.ToList();
        }

        public Product GetProductByNameAndId(string name, Guid productId)
        {
            return _context.Product.FirstOrDefault(p => p.Name == name && p.ProductId != productId);
        }
    }
}
