using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Areas.Writer.Controllers
{
[Area("Writer")]
[Authorize]
    public class HomeController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = announcementManager.GetList();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            var values =  announcementManager.GetById(id);
            return View(values);
        }
    }
}