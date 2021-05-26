using DataAccess.Abstract;
using DataAccess.Concrecte.Repostories;
using Entity.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfCategoryDal: GenericRepository<Category>, ICategoryDal
    {

    }
}
