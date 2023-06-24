using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesslayer.Abstract
{
    public interface IContactUsDal: IGenericDal<ContactUs>
    {
        List<ContactUs> GetListContactUsByTrue();
        List<ContactUs> GetListContactUsByFalse();
        void ContactUsChangeToTrue(int id);
        void ContactUsChangeToFalse(int id);
    }
}
