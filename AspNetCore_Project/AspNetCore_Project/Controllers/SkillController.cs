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
}