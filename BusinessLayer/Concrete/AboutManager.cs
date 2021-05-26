using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            throw new NotImplementedException();
        }

        public void AboutDelete(About about)
        {
            throw new NotImplementedException();
        }

        public void AboutUpdate(About about)
        {
            throw new NotImplementedException();
        }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            throw new NotImplementedException();
        }

        public List<About> GetListByHeadingID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
