using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrecte.Repostories
{
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;
        public void Delete(Writer p)
        {
            throw new NotImplementedException();
        }

        public Writer Get(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            throw new NotImplementedException();
        }
    }
}
