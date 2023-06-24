using DataAcsesslayer.Abstract;
using DataAcsesslayer.Concrete;
using DataAcsesslayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesslayer.Entityframework
{
    public class EfAccountDal : GenericUowRepository<Account>, IAccountDal
    {
        public EfAccountDal(Context context) : base(context)
        {

        }
    }
}
