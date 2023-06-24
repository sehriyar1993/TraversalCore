using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Abstarct
{
    public interface IdestinationServices:IGenericServices<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);
        public List<Destination> TGetLast4Destinations();
        public List<Destination> TGetLast6Destinations();


    }
}
