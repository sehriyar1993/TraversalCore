using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesslayer.Abstract
{
    public interface ICommentDal: IGenericDal<Commentler>
    {
        public List<Commentler> GetListCommentsWithDestination();
        public List<Commentler> GetListCommentsWithDestinationAndUser(int id);
    }
}
