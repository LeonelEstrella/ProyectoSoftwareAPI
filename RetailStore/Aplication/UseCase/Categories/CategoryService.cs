using Application.Interface.Categories;

namespace Application.UseCase.Categories
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
