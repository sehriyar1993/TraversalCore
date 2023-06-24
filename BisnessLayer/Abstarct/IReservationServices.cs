using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Abstarct
{
    public interface IReservationServices : IGenericServices<Reservation>
    {
       // List<Reservation> GetListApprovalreservation(int id);
        List<Reservation> GetListWithReservationsByWaitAproval(int id);
        List<Reservation> GetListWithReservationsByAccepted(int id);
        List<Reservation> GetListWithReservationsByPrevious(int id);
    }
}
