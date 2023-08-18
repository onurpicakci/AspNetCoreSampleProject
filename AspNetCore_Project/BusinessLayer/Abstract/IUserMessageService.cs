using EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface IUserMessageService : IGenericService<UserMessage>
{
    List<UserMessage> GetUserMessageWithUserService();
}