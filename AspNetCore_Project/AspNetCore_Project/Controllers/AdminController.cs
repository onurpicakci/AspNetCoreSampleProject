using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class AdminController : Controller
{
    public PartialViewResult PartialSideBar()
    {
        return PartialView();
    }
    
    public PartialViewResult PartialFooter()
    {
        return PartialView();
    }
    
    public PartialViewResult PartialNavBar()
    {
        return PartialView();
    }
    
    public PartialViewResult PartialHeader()
    {
        return PartialView();
    }
    
    public PartialViewResult PartialScripts()
    {
        return PartialView();
    }
    
    public PartialViewResult NavigationPartial()
    {
        return PartialView();
    }
}