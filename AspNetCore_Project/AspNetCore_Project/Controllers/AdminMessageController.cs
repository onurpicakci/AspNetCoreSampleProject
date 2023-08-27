using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        
        public IActionResult InboxMessageList()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListInboxMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListSendMessage(p);
            return View(values);
        }
        
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.GetById(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.GetById(id);
            writerMessageManager.Delete(values);
            return RedirectToAction("InboxMessageList");
        }
        
    }
}