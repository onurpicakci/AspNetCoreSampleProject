using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class AboutController : Controller
{
    AboutManager aboutManager = new AboutManager(new EfAboutDal());
    
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.v1 = "Update";
        ViewBag.v2 = "Highlights";
        ViewBag.v3 = "Highlight Page";
        var values = aboutManager.GetById(1);
        return View(values);
    }
    
    [HttpPost]
    public IActionResult Index(About about)
    {
        aboutManager.Update(about);
        return RedirectToAction("Index", "Default");
    }
}