using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Model
{
    public class Bilet
    {
        public int IdBilet { get; set; }
        public Client Client { get; set; }
        public Spectacol Spectacol { get; set; }
        public int NrLocuriCumparate { get; set; }

        public Bilet(int idBilet, Client client, Spectacol spec, int nrLoc)
        {
            this.IdBilet = idBilet;
            this.Client = client;
            this.Spectacol = spec;
            this.NrLocuriCumparate = nrLoc;
        }

    }
}
