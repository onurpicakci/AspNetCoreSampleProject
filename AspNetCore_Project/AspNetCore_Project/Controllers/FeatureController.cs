using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class FeatureController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}