using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Repository
{
    public interface RepoInterface<T>
    {
        int Size();
        void Add(T entity);
        void Delete(int idEntity);
        void Update(int idEntity, T newEntity);
        T GetById(int idEntity);
        ICollection<T> GetAll();
    }
}
