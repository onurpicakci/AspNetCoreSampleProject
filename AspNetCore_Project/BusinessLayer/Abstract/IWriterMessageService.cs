using EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface IWriterMessageService : IGenericService<WriterMessage>
{
    List<WriterMessage> GetListSendMessage(string p);
    
    List<WriterMessage> GetListInboxMessage(string p);
}