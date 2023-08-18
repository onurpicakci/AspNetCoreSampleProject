using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework;

public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
{
    public List<UserMessage> GetUserMessagesWithUser()
    {
        using (var context = new Context())
        {
            return context.UserMessages.Include(x => x.User).ToList();
        }
    }
}