using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Abstarct
{
    public interface IcommentServices: IGenericServices<Commentler>
    {
        List<Commentler> TGetDestinationById(int id);
        List<Commentler> TGetListCommentsWithDestination();
        public List<Commentler> TGetListCommentsWithDestinationAndUser(int id);

    }
}
