using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AnnouncementManager : IAnnouncementService
{
    IAnnouncementDal _announcementDal;

    public AnnouncementManager(IAnnouncementDal announcementDal)
    {
        _announcementDal = announcementDal;
    }

    public void Add(Announcement entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Announcement entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Announcement entity)
    {
        throw new NotImplementedException();
    }

    public List<Announcement> GetList()
    {
        return _announcementDal.GetList();
    }

    public Announcement GetById(int id)
    {
        return _announcementDal.GetById(id);
    }

    public List<Announcement> GetListbyFilter()
    {
        throw new NotImplementedException();
    }
}