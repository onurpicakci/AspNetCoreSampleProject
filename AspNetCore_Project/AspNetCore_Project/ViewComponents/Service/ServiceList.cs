using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Service;

public class ServiceList : ViewComponent
{
    private ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
    
    public IViewComponentResult Invoke()
    {
        var values = serviceManager.GetList();
        return View(values);
    }
}