using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival2._0.Service
{
    interface ServiceInterface<T>
    {
        int Size();
        void Add(T toAdd);
        void Update(T toUpdate, T updated);
        void Delete(T toDelete);
        bool Exists(T entity);
        ICollection<T> GetAll();
    }
}
