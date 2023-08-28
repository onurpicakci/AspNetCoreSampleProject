using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class AdminNavbarMessageList : ViewComponent
{
    private WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
    
    private readonly UserManager<WriterUser> _userManager;

    public AdminNavbarMessageList(UserManager<WriterUser> userManager)
    {
        _userManager = userManager;
    }

    public IViewComponentResult Invoke()
    {
        var userImage = _userManager.FindByNameAsync(User.Identity.Name).Result.ImageUrl;
        ViewBag.userImage = userImage;
        string p = "admin@gmail.com";
        var values = _writerMessageManager.GetListInboxMessage(p).OrderByDescending(x => x.Id).Take(3).ToList();
        return View(values);
    }
}