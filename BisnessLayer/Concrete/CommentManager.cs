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
    public class CommentManager : IcommentServices
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Commentler t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Commentler t)
        {
            _commentDal.Delete(t);
        }

        public Commentler TGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public List<Commentler> TGetList()
        {
            return _commentDal.GetList();
        }
        public List<Commentler> TGetDestinationById(int id)
        {
            return _commentDal.GetlistByfilter(x=>x.DestinationID == id);
        }

        public void TUpdate(Commentler t)
        {
            throw new NotImplementedException();
        }

        //public List<Commentler> TGetListCommentsWithDestination()
        //{
        //    return _commentDal.GetListCommentsWithDestination();
        //}

        public List<Commentler> TGetListCommentsWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentsWithDestinationAndUser(id);
        }

        public List<Commentler> TGetListCommentsWithDestination()
        {
            return _commentDal.GetListCommentsWithDestination();
        }
    }
}
