using BisnessLayer.Abstarct;
using DataAcsesslayer.Abstract;
using DataAcsesslayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Concrete
{

    public class IContactUsManager : IContactUsServices
    {
        IContactUsDal _contactUsDal;
        public ContactUs TGetByID(int id)
        {
            return _contactUsDal.GetByID(id);
        }
        public IContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs t)
        {
            _contactUsDal.Insert(t);
        }

        public void TContactUsChangeToFalse(int id)
        {
            _contactUsDal.ContactUsChangeToFalse(id);
        }

        public void TContactUsChangeToTrue(int id)
        {
            _contactUsDal.ContactUsChangeToTrue(id);
        }

        public void TDelete(ContactUs t)
        {
            _contactUsDal.Delete(t);
        }

        

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public void TUpdate(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}
