using Domain.Entities;

namespace Application.Interface.Categories
{
    public interface ICategoryQuery
    {
        Task<Category> GetById(int categoryId);
    }
}
