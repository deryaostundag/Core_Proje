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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDAL _TestimonialDAL;

        public TestimonialManager(ITestimonialDAL testimonialDAL)
        {
            _TestimonialDAL = testimonialDAL;
        }

        public void TAdd(Testimonial t)
        {
            _TestimonialDAL.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _TestimonialDAL.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _TestimonialDAL.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _TestimonialDAL.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            _TestimonialDAL.Update(t);
        }
    }
}
