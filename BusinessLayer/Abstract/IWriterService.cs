using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void WriterAdd(Writer writer);
        void WriterDelete(Writer writer);
        void WriterUpdate(Writer writer);
        Writer GetById(int id);
    }
}
