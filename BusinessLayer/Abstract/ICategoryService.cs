using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
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
