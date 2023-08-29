using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class WriterManager : IWriterService
{
   private readonly IWriterDal _writerDal;

    public WriterManager(IWriterDal writerDal)
    {
        _writerDal = writerDal;
    }

    public void Add(WriterUser entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(WriterUser entity)
    {
        throw new NotImplementedException();
    }

    public void Update(WriterUser entity)
    {
        throw new NotImplementedException();
    }

    public List<WriterUser> GetList()
    {
        return _writerDal.GetList();
    }

    public WriterUser GetById(int id)
    {
        return _writerDal.GetById(id);
    }

    public List<WriterUser> GetListbyFilter()
    {
        throw new NotImplementedException();
    }
}