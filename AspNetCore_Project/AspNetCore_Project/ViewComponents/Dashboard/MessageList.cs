using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class MessageList : ViewComponent
{
   public IViewComponentResult Invoke()
   {
      return View();
   } 
}