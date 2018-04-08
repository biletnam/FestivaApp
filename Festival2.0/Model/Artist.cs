using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Model
{
    public class Artist
    {
        public int IdArtist { get; set; }
        public String Nume{ get; set; }

        public Artist(int idArtist, String nume)
        {
            this.IdArtist = idArtist;
            this.Nume = nume;
        }

        public override string ToString()
        {
            return Nume;
        }
    }
}
