using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class FeatureController : Controller
{
    FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.v1 = "Update";
        ViewBag.v2 = "Highlights";
        ViewBag.v3 = "Highlight Page";
        var values = featureManager.GetById(1);
        return View(values);
    }
    
    [HttpPost]
    public IActionResult Index(Feature feature)
    {
        featureManager.Update(feature);
        return RedirectToAction("Index", "Default");
    }
    
    
    
}