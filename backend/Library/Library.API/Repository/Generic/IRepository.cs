using System.Collections.Generic;

namespace Library.API.Repository.Generic
{
    public interface IRepository<T>
    {
        T Create(T t);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T t);
        void Delete(long id);
        bool Exists(long id);
    }
}
