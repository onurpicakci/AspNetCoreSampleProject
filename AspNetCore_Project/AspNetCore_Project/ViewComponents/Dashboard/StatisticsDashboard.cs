using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class StatisticsDashboard : ViewComponent
{
    public Context context = new Context();
    public IViewComponentResult Invoke()
    {
        ViewBag.v1 = context.Portfolios.Count();
        ViewBag.v2 = context.Messages.Count();
        ViewBag.v3 = context.Services.Count();
        return View();
    }
}