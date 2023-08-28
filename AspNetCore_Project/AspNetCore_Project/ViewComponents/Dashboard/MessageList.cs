using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class MessageList : ViewComponent
{
   MessageManager _messageManager = new MessageManager(new EfMessageDal());
   public IViewComponentResult Invoke()
   {
      var values = _messageManager.GetList();
      return View(values);
   } 
}