using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}