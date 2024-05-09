using Domain.Entities;

namespace Application.Interface.CategoryInterfaces
{
    public interface ICategoryQuery
    {
        Task<Category> GetById(int categoryId);
    }
}
