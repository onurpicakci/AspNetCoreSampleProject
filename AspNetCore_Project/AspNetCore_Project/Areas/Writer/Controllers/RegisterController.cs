using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Areas.Writer.Controllers;

[Area("Writer")]
public class RegisterController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string name, string surname, string email, string password, string passwordConfirm)
    {
        return View();
    }
}