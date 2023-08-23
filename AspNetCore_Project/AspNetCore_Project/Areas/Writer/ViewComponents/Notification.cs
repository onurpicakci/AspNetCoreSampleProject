using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Areas.Writer.ViewComponents;

public class Notification : ViewComponent
{
    private AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());
    
    public IViewComponentResult Invoke()
    {
        var values = _announcementManager.GetList().Take(3).ToList();
        return View(values);
    }
}