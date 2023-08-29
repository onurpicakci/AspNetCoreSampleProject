using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AspNetCore_Project.Controllers
{
    public class WriterUserController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        
        public IActionResult Index()
        {
            var values = writerManager.GetList();
            return View(values);
        }
        
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerManager.GetList());
            return Json(values);
        }
        
        public IActionResult GetByWriterId(int id)
        {
            var getId = writerManager.GetById(id);
            var values = JsonConvert.SerializeObject(getId);
            return Json(values);
        }
        
        public IActionResult DeleteWriter(int id)
        {
            var writerUser = writerManager.GetById(id);
            writerManager.Delete(writerUser);
            return RedirectToAction("Index");
        }
    }
}