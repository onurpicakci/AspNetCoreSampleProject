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
        var values = experienceManager.GetList();
        return View(values);
    }
    
    [HttpGet]
    public IActionResult AddExperience()
    {
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