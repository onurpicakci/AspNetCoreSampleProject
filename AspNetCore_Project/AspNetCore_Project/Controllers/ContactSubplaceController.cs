using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers
{
    public class ContactSubplaceController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        
        public IActionResult Index()
        {
           var values = contactManager.GetById(1);
            return View(values);
        }
        
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactManager.Update(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}