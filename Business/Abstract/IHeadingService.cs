using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        void HeadingAdd(Heading heading);
        Heading GetByID(int id);
        void HeadingDelete(Heading heading);
        void HeadingUpdate(Heading heading);
    }
}
