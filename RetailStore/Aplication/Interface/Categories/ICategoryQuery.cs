using Domain.Entities;

namespace Application.Interface.Categories
{
    public interface ICategoryQuery
    {
        Category GetById(int categoryId);
    }
}
