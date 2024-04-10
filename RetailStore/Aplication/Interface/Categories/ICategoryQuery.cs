using Domain.Entities;

namespace Aplication.Interface.Categories
{
    public interface ICategoryQuery
    {
        Category GetById(int categoryId);
    }
}
