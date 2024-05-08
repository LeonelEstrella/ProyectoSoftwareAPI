using Domain.Entities;

namespace Application.Interface.Categories
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryById(int categoryId);
    }
}
