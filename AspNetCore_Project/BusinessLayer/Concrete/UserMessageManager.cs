using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class UserMessageManager : IUserMessageService
{
    IUserMessageDal _userMessageDal;

    public UserMessageManager(IUserMessageDal userMessageDal)
    {
        _userMessageDal = userMessageDal;
    }
    
    public void Add(UserMessage entity)
    {
        _userMessageDal.Insert(entity);
    }

    public void Delete(UserMessage entity)
    {
        _userMessageDal.Delete(entity);
    }

    public void Update(UserMessage entity)
    {
        throw new NotImplementedException();
    }

    public List<UserMessage> GetList()
    {
        return _userMessageDal.GetList();
    }

    public UserMessage GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<UserMessage> GetListbyFilter()
    {
        throw new NotImplementedException();
    }

    public List<UserMessage> GetUserMessageWithUserService()
    {
        return _userMessageDal.GetUserMessagesWithUser();
    }
}