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
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        
        public IActionResult Index()
        {
            var values = socialMediaManager.GetList();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.Status = true;
            socialMediaManager.Add(socialMedia);
            return RedirectToAction("Index");
        }
        
        public IActionResult DeleteSocialMedia(int id)
        {
            var socialMediaValue = socialMediaManager.GetById(id);
            socialMediaManager.Delete(socialMediaValue);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var socialMediaValue = socialMediaManager.GetById(id);
            return View(socialMediaValue);
        }
        
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            socialMediaManager.Update(socialMedia);
            return RedirectToAction("Index");
        }
    }
}