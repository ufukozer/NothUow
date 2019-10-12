using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthUow.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T entity);
        void Delete(int id);
    }
}
