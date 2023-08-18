using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract;

public interface IUserMessageDal : IGenericDal<UserMessage>
{
    public List<UserMessage> GetUserMessagesWithUser();
}