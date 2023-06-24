using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Abstarct
{
    public interface IGenericServices<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
       // List<T> GetByfilter(Exception<Func<T,bool>>filter);
    }
}
