using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Model
{
    public class Spectacol
    {
        public int IdSpectacol { get; set; }
        public Artist Artist { get; set; }
        public String DataSpectacol { get; set; }
        public String OraSpectacol { get; set; }
        public String LocSpectacol { get; set; }
        public int NrLocuri { get; set; }
        public int NrLocuriVandute { get; set; }

        public Spectacol(int idSpectacol, Artist artist, String dataSpec, String oraSpec, String locSpec, int nrLoc, int nrLocVandute)
        {
            this.IdSpectacol = idSpectacol;
            this.Artist = artist;
            this.DataSpectacol = dataSpec;
            this.OraSpectacol = oraSpec;
            this.LocSpectacol = locSpec;
            this.NrLocuri = nrLoc;
            this.NrLocuriVandute = nrLocVandute;
        }


    }
}
