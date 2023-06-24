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
    public class EFAboutDal:GenericRepository<About>, IAboutDal
    {
        public void ChangeToFalseGuide(int id)
        {
            Context contex = new Context();
            var values = contex.Abouts.Find(id);
            values.Status = false;
            contex.Update(values);
            contex.SaveChanges();

        }

        public void ChangeToTrueGuide(int id)
        {
            Context contex = new Context();
            var values = contex.Abouts.Find(id);
            values.Status = true;
            contex.Update(values);
            contex.SaveChanges();
        }
    }
}
