using Festival.Model;
using Festival2._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Festival.Repository
{
    public class BileteRepo : IBileteRepo
    {
        IDictionary<string, string> props;
        public BileteRepo(IDictionary<string,string> props)
        {
            this.props = props;
        }


        public void Add(Bilet entity)
        {
            var connection = DButils.getConnection(props);

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "insert into Bilete(IdClient,IdSpectacol,NrLocuri) values(@idClient,@idSpectacol,@nrLocuri)";
                var idC = comm.CreateParameter();
                idC.ParameterName = "@idClient";
                idC.Value = entity.Client.IdClient;
                comm.Parameters.Add(idC);

                var idS = comm.CreateParameter();
                idS.ParameterName = "@idSpectacol";
                idS.Value = entity.Spectacol.IdSpectacol;
                comm.Parameters.Add(idS);

                var nrL = comm.CreateParameter();
                nrL.ParameterName = "@nrLocuri";
                nrL.Value = entity.NrLocuriCumparate;
                comm.Parameters.Add(nrL);

                try
                {
                    comm.ExecuteNonQuery();
                    Console.WriteLine("Adaugare bilet efectuata!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Eroare bilet " + e.Message);

                }

            }

        }

        public void Delete(int idEntity)
        {
            //throw new NotImplementedException();
        }

        public ICollection<Bilet> GetAll()
        {
            return null;
        }

        public Bilet GetById(int idEntity)
        {
            //throw new NotImplementedException();
            return null;
        }

        public int Size()
        {
            //throw new NotImplementedException();
            return 0;
        }

        public void Update(int idEntity, Bilet newEntity)
        {
            //throw new NotImplementedException();
        }
    }
}
