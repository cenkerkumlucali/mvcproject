using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        List<About> GetListByHeadingID(int id);
        void AboutAdd(About about);
        About GetByID(int id);
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
