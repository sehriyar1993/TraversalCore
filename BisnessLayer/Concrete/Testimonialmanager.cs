using BisnessLayer.Abstarct;
using DataAcsesslayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Concrete
{
    public class Testimonialmanager: ITestimonialServices
    {
        ITestimonialDal testimonialDal;

        public Testimonialmanager(ITestimonialDal testimonialDal)
        {
            this.testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return testimonialDal.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
