using DataAcsesslayer.Abstract;
using DataAcsesslayer.Concrete;
using DataAcsesslayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesslayer.Entityframework
{
    public class EFContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        Context c = new Context();
        public void ContactUsChangeToFalse(int id)
        {
           
            var values = c.ContactUss.Find(id);
            values.MessageStatus = false;
            c.Update(values);
            c.SaveChanges();
        }

        public void ContactUsChangeToTrue(int id)
        {
            var values = c.ContactUss.Find(id);
            values.MessageStatus = true;
            c.Update(values);
            c.SaveChanges(); ;
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            var values = c.ContactUss.Where(x=>x.MessageStatus==false).ToList();
            return values;
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            var values = c.ContactUss.Where(x => x.MessageStatus == true).ToList();
            return values;
        }
    }
}
