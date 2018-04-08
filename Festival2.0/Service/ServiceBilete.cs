using Festival.Model;
using Festival.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival2._0.Service
{
    public class ServiceBilete : ServiceInterface<Bilet>
    {
        private BileteRepo repo;
        private ServiceClienti serviceC;
        private ServiceSpectacole serviceS;

        public ServiceBilete(BileteRepo br, ServiceClienti sc, ServiceSpectacole ss)
        {
            this.repo = br;
            this.serviceC = sc;
            this.serviceS = ss;
        }

        public void Add(Bilet toAdd)
        {
            serviceC.Add(toAdd.Client);
            serviceS.UpdateNrLocuri(toAdd.Spectacol.IdSpectacol, toAdd.NrLocuriCumparate);
            repo.Add(toAdd);
        }

        public void Delete(Bilet toDelete)
        {
            //throw new NotImplementedException();
        }

        public bool Exists(Bilet entity)
        {
            //throw new NotImplementedException();
            return false;
        }

        public ICollection<Bilet> GetAll()
        {
            //throw new NotImplementedException();
            return null;
        }

        public int Size()
        {
            //throw new NotImplementedException();
            return 0;
        }

        public void Update(Bilet toUpdate, Bilet updated)
        {
            //throw new NotImplementedException();
        }
    }
}
