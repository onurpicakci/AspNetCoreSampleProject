using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public  class TestimonialManager: ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonials entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void Delete(Testimonials entity)
        {
            _testimonialDal.Delete(entity);
        }

        public List<Testimonials> GetList()
        {
            return _testimonialDal.GetList();
        }

        public Testimonials GetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public void Update(Testimonials entity)
        {
            _testimonialDal.Update(entity);
        }

        public List<Testimonials> GetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
