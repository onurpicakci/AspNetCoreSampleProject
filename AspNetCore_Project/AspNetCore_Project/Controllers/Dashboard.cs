using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class Dashboard : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}