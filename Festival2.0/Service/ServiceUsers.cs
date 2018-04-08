using Festival.Model;
using Festival.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival2._0.Service
{
   public class ServiceUsers : ServiceInterface<User>
    {
        private UsersRepo repo;

        public ServiceUsers(UsersRepo repoUsers)
        {
            this.repo = repoUsers;
        }

        public void Add(User toAdd)
        {
          //  throw new NotImplementedException();
        }

        public void Delete(User toDelete)
        {
            //throw new NotImplementedException();
        }

        public bool Exists(User entity)
        {
            return repo.exists(entity.UserName, entity.Password);
        }

        public ICollection<User> GetAll()
        {
            //throw new NotImplementedException();

            return null;
        }

        public int Size()
        {
            //throw new NotImplementedException();
            return 0;
        }

        public void Update(User toUpdate, User updated)
        {
            //throw new NotImplementedException();
        }
    }
}
