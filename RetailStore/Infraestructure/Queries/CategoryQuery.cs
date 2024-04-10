using Aplication.Interface.Categories;
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

        public Category GetById(int categoryId)
        {
            return _context.Category.FirstOrDefault(c => c.CategoryId == categoryId);
        }
    }
}
