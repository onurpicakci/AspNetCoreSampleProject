using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Testimonial;

public class TestimonialList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        
        var values = testimonialManager.GetList();
        return View(values);
    }
}