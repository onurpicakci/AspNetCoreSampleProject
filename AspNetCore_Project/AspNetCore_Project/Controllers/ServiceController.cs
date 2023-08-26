using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class ServiceController : Controller
{
    private ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
    
    public IActionResult Index()
    {
        var values = serviceManager.GetList();
        return View(values);
    }
    
    [HttpGet]
    public IActionResult AddService()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult AddService(Service service)
    {
        serviceManager.Add(service);
        return RedirectToAction("Index");
    }
    
    public IActionResult DeleteService(int id)
    {
        var serviceValue = serviceManager.GetById(id);
        serviceManager.Delete(serviceValue);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult UpdateService(int id)
    {
        var serviceValue = serviceManager.GetById(id);
        return View(serviceValue);
    }
    
    [HttpPost]
    public IActionResult UpdateService(Service service)
    {
        serviceManager.Update(service);
        return RedirectToAction("Index");
    }
}