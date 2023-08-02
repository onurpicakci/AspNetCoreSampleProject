using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class FeatureStatistics : ViewComponent
{
     public Context context = new Context();
    public IViewComponentResult Invoke()
    {
        ViewBag.v1 = context.Skills.Count();
        ViewBag.v2 = context.Messages.Count(x => x.IsRead == false);
        ViewBag.v3 = context.Messages.Count(x => x.IsRead == true);
        ViewBag.v4 = context.Experiences.Count();
        return View();
    }
}