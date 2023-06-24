namespace BisnessLayer.Abstarct.AbstractUow
{
    public interface IGenericUowService<T>
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TMultiUpdate(List<T> t);
        T TGetByID(int id);
    }
}