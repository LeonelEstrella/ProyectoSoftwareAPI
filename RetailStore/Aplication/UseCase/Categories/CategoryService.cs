using Aplication.Interface.Categories;
using Domain.Entities;

namespace Aplication.UseCase.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryQuery _query;

        public CategoryService(ICategoryQuery query)
        {
            _query = query;
        }

        public string GetCategoryById(int categoryId)
        {
           var category = _query.GetById(categoryId);
           return  category.Name;
        }
    }
}
