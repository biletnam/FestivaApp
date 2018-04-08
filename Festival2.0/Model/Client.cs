using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Model
{
    public class Client
    {
        public int IdClient { get; set; }
        public String Nume { get; set; }

        public Client(int idClient, String nume)
        {
            this.IdClient = idClient;
            this.Nume = nume;
        }

    }
}
