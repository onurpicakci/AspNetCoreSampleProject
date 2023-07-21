using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Experience;

public class ExperienceList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        var values = experienceManager.GetList();
        return View(values);
    }
}