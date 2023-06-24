using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesslayer.Abstract
{
    public interface IAboutDal: IGenericDal<About>
    {
        void ChangeToTrueGuide(int id);
        void ChangeToFalseGuide(int id);
    }
}
