using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class VisitorMap : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}