using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public PartialViewResult HeaderPartial()
    {
        return PartialView();
    }
    
    public PartialViewResult NavBarPartial()
    {
        return PartialView();
    }
}