using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAdd(Category category);
        Category GetByID(int id);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
    }
}
