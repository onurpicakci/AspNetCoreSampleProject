using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> RecieverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values?.Email;
            var messageList = _writerMessageManager.GetListInboxMessage(p);
            return View(messageList);
        }
        
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values?.Email;
            var messageList = _writerMessageManager.GetListSendMessage(p);
            return View(messageList);
        }
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = _writerMessageManager.GetById(id);
            return View(writerMessage);
        }
        
        public IActionResult SenderMessageDetails(int id)
        {
            WriterMessage writerMessage = _writerMessageManager.GetById(id);
            return View(writerMessage);
        }
    }
}