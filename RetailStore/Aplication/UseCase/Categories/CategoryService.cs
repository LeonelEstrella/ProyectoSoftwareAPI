using Application.Interface.Categories;
using Domain.Entities;

namespace Application.UseCase.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryQuery _query;

        public CategoryService(ICategoryQuery query)
        {
            _query = query;
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
           return await _query.GetById(categoryId);
        }
    }
}
