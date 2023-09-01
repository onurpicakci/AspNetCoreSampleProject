using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

[AllowAnonymous]
public class DefaultController : Controller
{
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

    [HttpGet]
    public PartialViewResult SendMessage()
    {
        return PartialView();
    }
    
    [HttpPost]
    public PartialViewResult SendMessage(Message message)
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        message.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
        message.IsRead = true; 
        messageManager.Add(message);
        return PartialView();
    }
}