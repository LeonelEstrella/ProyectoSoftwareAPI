using Domain.Entities;

namespace Application.Interface.CategoryInterfaces
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryById(int categoryId);
    }
}
