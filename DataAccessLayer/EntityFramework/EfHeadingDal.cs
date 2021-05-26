using DataAccessLayer.Abstract;
using DataAccessLayer.Concrecte.Repostories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfHeadingDal: GenericRepository<Heading>, IHeadingDal
    {
    }
}
