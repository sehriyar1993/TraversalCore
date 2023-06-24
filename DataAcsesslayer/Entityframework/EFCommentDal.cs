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
    public class EFCommentDal : GenericRepository<Commentler>, ICommentDal
    {
        public List<Commentler> GetListCommentsWithDestination()
        {
            using(var c=new Context())
            {
                return c.Commentlers.Include(x=>x.Destination).ToList();
            }
        }

        public List<Commentler> GetListCommentsWithDestinationAndUser(int id)
        {
            using (var c = new Context())
            {
                return c.Commentlers.Where(x=>x.DestinationID==id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
