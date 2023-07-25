using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class ExperienceController : Controller
{
    ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
    
    public IActionResult Index()
    {
        ViewBag.v1 = "Experience List";
        ViewBag.v2 = "Experience";
        ViewBag.v3 = "Experience List";
        var values = experienceManager.GetList();
        return View(values);
    }
    
    [HttpGet]
    public IActionResult AddExperience()
    {
        ViewBag.v1 = "Add New Experience";
        ViewBag.v2 = "Experience";
        ViewBag.v3 = "Add New Experience";
        return View();
    }
    
    [HttpPost]
    public IActionResult AddExperience(Experience experience)
    {
        experienceManager.Add(experience);
        return RedirectToAction("Index");
    }
    
    public IActionResult DeleteExperience(int id)
    {
        var experienceValue = experienceManager.GetById(id);
        experienceManager.Delete(experienceValue);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult UpdateExperience(int id)
    {
        ViewBag.v1 = "Update Experience";
        ViewBag.v2 = "Experience";
        ViewBag.v3 = "Update Experience";
        var experienceValue = experienceManager.GetById(id);
        return View(experienceValue);
    }
    
    [HttpPost]
    public IActionResult UpdateExperience(Experience experience)
    {
        experienceManager.Update(experience);
        return RedirectToAction("Index");
    }
}