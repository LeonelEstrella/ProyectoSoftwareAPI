using Domain.Entities;

namespace Application.Interface.Categories
{
    public interface ICategoryService
    {
        Category GetCategoryById(int categoryId);
    }
}
