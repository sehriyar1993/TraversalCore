using DataAcsesslayer.Abstract;
using DataAcsesslayer.Concrete;
using DataAcsesslayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesslayer.Entityframework
{
    public class EFReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        //public void ChangeToFalseGuide(int id)
        //{
        //    Context contex = new Context();
        //    var values = contex.Reservations.Find(id);
        //    values.Status = false;
        //    contex.Update(values);
        //    contex.SaveChanges();

        //}

        //public void ChangeToTrueGuide(int id)
        //{
        //    Context contex = new Context();
        //    var values = contex.Reservations.Find(id);
        //    values.Status = true;
        //    contex.Update(values);
        //    contex.SaveChanges();
        //}
        public List<Reservation> GetListWithReservationsByAccepted(int id)
        {
            using (var context = new Context())
            {

                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Təsdiqlənib" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationsByPrevious(int id)
        {
            using (var context = new Context())
            {

                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Müddəti Bitib" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationsByWaitAproval(int id)
        {
            using (var context = new Context()) 
            {

                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Təsdiq Gözləyir" && x.AppUserId==id).ToList();
            } 
        }
    }
}
