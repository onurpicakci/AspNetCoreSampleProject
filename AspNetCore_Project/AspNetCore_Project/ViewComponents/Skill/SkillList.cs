using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Skill;

public class SkillList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        
        var values = skillManager.GetList();
        return View(values);
    }
}