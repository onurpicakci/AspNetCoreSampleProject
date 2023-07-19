using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.About;

public class AboutList : ViewComponent
{
    private AboutManager aboutManager = new AboutManager(new EfAboutDal());
    
    public IViewComponentResult Invoke()
    {
        var values = aboutManager.GetList();
        return View(values);
    }
}