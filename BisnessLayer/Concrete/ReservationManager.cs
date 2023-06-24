using BisnessLayer.Abstarct;
using DataAcsesslayer.Abstract;
using DataAcsesslayer.Entityframework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Concrete
{
    public class ReservationManager : IReservationServices
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListWithReservationsByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationsByAccepted(id);
        }

        public List<Reservation> GetListWithReservationsByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationsByPrevious(id);
        }

        public List<Reservation> GetListWithReservationsByWaitAproval(int id)
        {
            return _reservationDal.GetListWithReservationsByWaitAproval(id);
        }

        //public List<Reservation> GetListApprovalreservation(int id)
        //{
        //    return _reservationDal.GetlistByfilter(x=>x.AppUserId == id && x.Status == "Təsdiq Gözləyir");
        //}

        public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByID(int id)
        {
            return _reservationDal.GetByID(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }
    }
}
