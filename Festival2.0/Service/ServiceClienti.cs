using Festival.Model;
using Festival.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival2._0.Service
{
    public class ServiceClienti : ServiceInterface<Client>
    {
        private ClientiRepo repoClienti;

        public ServiceClienti(ClientiRepo repoC)
        {
            this.repoClienti = repoC;
        }

        public void Add(Client toAdd)
        {
            repoClienti.Add(toAdd);
        }

        public void Delete(Client toDelete)
        {
            //throw new NotImplementedException();
        }

        public bool Exists(Client entity)
        {
            //throw new NotImplementedException();
            return false;
        }

        public ICollection<Client> GetAll()
        {
            //throw new NotImplementedException();
            return null;
        }

        public int Size()
        {
            //throw new NotImplementedException();
            return 0;
        }

        public void Update(Client toUpdate, Client updated)
        {
            //throw new NotImplementedException();
        }
    }
}
