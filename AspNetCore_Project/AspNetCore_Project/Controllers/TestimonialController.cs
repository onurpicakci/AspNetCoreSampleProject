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
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        
        public IActionResult Index()
        {
            var values = testimonialManager.GetList();
            return View(values);
        }
        
        public IActionResult DeleteTestimonial(int id)
        {
            var testimonialValue = testimonialManager.GetById(id);
            testimonialManager.Delete(testimonialValue);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var testimonialValue = testimonialManager.GetById(id);
            return View(testimonialValue);
        }
        
        [HttpPost]
        public IActionResult UpdateTestimonial(int id, Testimonials p)
        {
            var testimonialValue = testimonialManager.GetById(id);
            testimonialValue.ClientName = p.ClientName;
            testimonialValue.Company = p.Company;
            testimonialValue.ImageUrl = p.ImageUrl;
            testimonialValue.Comment = p.Comment;
            testimonialManager.Update(testimonialValue);
            return RedirectToAction("Index");
        }
        
    }
}