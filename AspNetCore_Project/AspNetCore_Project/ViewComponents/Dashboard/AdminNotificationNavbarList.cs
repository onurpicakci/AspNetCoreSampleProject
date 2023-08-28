using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class AdminNotificationNavbarList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}