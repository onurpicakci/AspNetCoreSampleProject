using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]")]
    public class MessageController : Controller
    {
        WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [Route("")]
        [Route("RecieverMessage")]
        public async Task<IActionResult> RecieverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values?.Email;
            var messageList = _writerMessageManager.GetListInboxMessage(p);
            return View(messageList);
        }

        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values?.Email;
            var messageList = _writerMessageManager.GetListSendMessage(p);
            return View(messageList);
        }

        [Route("")]
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = _writerMessageManager.GetById(id);
            return View(writerMessage);
        }

        [Route("")]
        [Route("SendMessageDetails/{id}")]
        public IActionResult SenderMessageDetails(int id)
        {
            WriterMessage writerMessage = _writerMessageManager.GetById(id);
            return View(writerMessage);
        }

        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string email = values.Email;
            string name = values.Name + " " + values.Surname;
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Sender = email;
            p.SenderName = name;
            Context c = new Context();
            var userNameSurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname)
                .FirstOrDefault();
            p.ReceiverName = userNameSurname;
            _writerMessageManager.Add(p);
            return RedirectToAction("SenderMessage");
        }
    }
}