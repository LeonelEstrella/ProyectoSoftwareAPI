using Application.Interface.CategoryInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Queries
{
    public class CategoryQuery : ICategoryQuery
    {
        private readonly AppDbContext _context;

        public CategoryQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Category> GetById(int categoryId)
        {
            return await _context.Category.FirstOrDefaultAsync(c => c.CategoryId == categoryId);
        }
    }
}
