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
        var values = skillManager.GetList();
         return View(values);
     }
    
    [HttpGet]
    public IActionResult AddSkill()
    {
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