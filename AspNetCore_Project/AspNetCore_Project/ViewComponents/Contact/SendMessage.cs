using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Contact;

public class SendMessage : ViewComponent
{
    MessageManager messageManager = new MessageManager(new EfMessageDal());
    
    [HttpGet]
    public IViewComponentResult Invoke()
    {
        return View();
    }

    // [HttpPost]
    // public IViewComponentResult Invoke(Message message)
    // {
    //     message.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
    //     message.IsRead = true; 
    //     messageManager.Add(message);
    //     return View();
    // }
}