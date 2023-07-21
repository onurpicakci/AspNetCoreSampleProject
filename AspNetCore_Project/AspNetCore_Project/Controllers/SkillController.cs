using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class SkillController : Controller
{
     public IActionResult Index()
     {
         return View();
     }
}