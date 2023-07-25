using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class SkillController : Controller
{
    SkillManager skillManager = new SkillManager(new EfSkillDal());
    public IActionResult Index()
    {
        ViewBag.v1 = "Skill List";
        ViewBag.v2 = "Skills";
        ViewBag.v3 = "Skill List";
        var values = skillManager.GetList();
         return View(values);
     }
    
    [HttpGet]
    public IActionResult AddSkill()
    {
        ViewBag.v1 = "Add New Skill";
        ViewBag.v2 = "Skills";
        ViewBag.v3 = "Add New Skill";
        return View();
    }
    
    [HttpPost]
    public IActionResult AddSkill(Skill skill)
    {
        skillManager.Add(skill);
        return RedirectToAction("Index");
    }
    
    public IActionResult DeleteSkill(int id)
    {
        var skillValue = skillManager.GetById(id);
        skillManager.Delete(skillValue);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult UpdateSkill(int id)
    {
        ViewBag.v1 = "Update Skill";
        ViewBag.v2 = "Skills";
        ViewBag.v3 = "Update Skill";
        var skillValue = skillManager.GetById(id);
        return View(skillValue);
    }
    
    [HttpPost]
    public IActionResult UpdateSkill(Skill skill)
    {
        skillManager.Update(skill);
        return RedirectToAction("Index");
    }
}