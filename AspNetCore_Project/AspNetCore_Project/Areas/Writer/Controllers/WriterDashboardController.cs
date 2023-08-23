using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class WriterDashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public WriterDashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Result.Name + " " + values.Result.Surname;
            
            // weather api
            
            string api = "503406f4fc625d91168b358a17238c92";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=bursa&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.weather = document.Descendants("temperature").FirstOrDefault()?.Attribute("value").Value;
            
            //statistics
            Context context = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = context.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = context.Skills.Count();
            
            return View();
        }
    }
}