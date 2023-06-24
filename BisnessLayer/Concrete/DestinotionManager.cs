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
    public class DestinotionManager:IdestinationServices
    {
        IDestinationDal _destinationDal;

        public DestinotionManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetByID(int id)
        {
            return _destinationDal.GetByID(id);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> TGetLast4Destinations()
        {
            return _destinationDal.GetLast4Destinations();
        }

		public List<Destination> TGetLast6Destinations()
		{
			return _destinationDal.GetLast6Destinations();
		}

		public List<Destination> TGetList()
        {
          return  _destinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
