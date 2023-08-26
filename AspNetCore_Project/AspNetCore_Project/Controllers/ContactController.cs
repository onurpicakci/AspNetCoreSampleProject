
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        
        public IActionResult Index()
        {
            var values = messageManager.GetList();
            return View(values);
        }
        
        public IActionResult DeleteMessage(int id)
        {
            var messageValue = messageManager.GetById(id);
            messageManager.Delete(messageValue);
            return RedirectToAction("Index");
        }
        
        public IActionResult ContactDetails(int id)
        {
            var values = messageManager.GetById(id);
            return View(values);
        }
    }
}