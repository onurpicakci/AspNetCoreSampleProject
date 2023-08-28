using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class AdminFooterList : ViewComponent
{
    SocialMediaManager _socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
    
    public IViewComponentResult Invoke()
    {
        var values = _socialMediaManager.GetList();
        return View(values);
    }
}