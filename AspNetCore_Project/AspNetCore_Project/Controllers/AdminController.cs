using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class AdminController : Controller
{
    public PartialViewResult SideBar()
    {
        return PartialView();
    }
}