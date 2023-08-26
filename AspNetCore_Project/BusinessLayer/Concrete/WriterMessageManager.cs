using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class WriterMessageManager : IWriterMessageService
{
    IWriterMessageDal _writerMessageDal;

    public WriterMessageManager(IWriterMessageDal writerMessageDal)
    {
        _writerMessageDal = writerMessageDal;
    }

    public void Add(WriterMessage entity)
    {
        _writerMessageDal.Insert(entity);
    }

    public void Delete(WriterMessage entity)
    {
        throw new NotImplementedException();
    }

    public void Update(WriterMessage entity)
    {
        throw new NotImplementedException();
    }

    public List<WriterMessage> GetList()
    {
        throw new NotImplementedException();
    }

    public WriterMessage GetById(int id)
    {
        return _writerMessageDal.GetById(id);
    }

    public List<WriterMessage> GetListbyFilter()
    {
        throw new NotImplementedException();
    }
    
    public List<WriterMessage> GetListSendMessage(string p)
    {
        return _writerMessageDal.GetByFilter(x => x.Sender == p);
    }

    public List<WriterMessage> GetListInboxMessage(string p)
    {
        return _writerMessageDal.GetByFilter(x => x.Receiver == p);
    }
}