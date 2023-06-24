using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesslayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationsByWaitAproval(int id);
        List<Reservation> GetListWithReservationsByAccepted(int id);
        List<Reservation> GetListWithReservationsByPrevious(int id);
        //void ChangeToTrueGuide(int id);
        //void ChangeToFalseGuide(int id);
    }
}
