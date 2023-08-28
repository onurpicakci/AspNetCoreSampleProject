using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.SocialMedia;

public class SocialMediaList : ViewComponent
{
    SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
    
    public IViewComponentResult Invoke()
    {
        var values = socialMediaManager.GetList();
        return View(values);
    }
}