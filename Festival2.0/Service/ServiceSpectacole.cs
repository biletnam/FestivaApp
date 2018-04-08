using Festival.Model;
using Festival.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival2._0.Service
{
    public class ServiceSpectacole : ServiceInterface<Spectacol>
    {

        private SpectacoleRepo repo;

        public ServiceSpectacole(SpectacoleRepo repoSpec)
        {
            this.repo = repoSpec;
        }

        public void Add(Spectacol toAdd)
        {
           // throw new NotImplementedException();
        }

        public void Delete(Spectacol toDelete)
        {
           // throw new NotImplementedException();
        }

        public bool Exists(Spectacol entity)
        {
            //throw new NotImplementedException();
            return false;
        }

        public ICollection<Spectacol> GetAll()
        {
            
            return repo.GetAll();
        }

        public int Size()
        {
            // throw new NotImplementedException();
            return 0;
        }

        public void Update(Spectacol toUpdate, Spectacol updated)
        {
            //throw new NotImplementedException();
        }

        public void UpdateNrLocuri(int idSpectacol, int nrLocuriVandute)
        {
            repo.UpdateNrLocuri(idSpectacol, nrLocuriVandute);
        }
    }
}
