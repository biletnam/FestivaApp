using Festival.Model;
using Festival2._0.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Festival.Repository
{
    public class SpectacoleRepo : ISpectacolRepo
    {
        IDictionary<string, string> props;

        public SpectacoleRepo(IDictionary<string, string> props)
        {
            this.props = props;
        }

        public void Add(Spectacol entity)
        {
            //throw new NotImplementedException();
        }

        public void Delete(int idEntity)
        {
           // throw new NotImplementedException();
        }

        public ICollection<Spectacol> GetAll()
        {
            IDbConnection connection = DButils.getConnection(props);
            IList<Spectacol> spectacole = new List<Spectacol>();

            using(var command = connection.CreateCommand())
            {
                command.CommandText = "select a.IdArtist,a.Nume,s.IdSpectacol,s.DataSpectacol,s.OraSpectacol,s.LocSpectacol,s.NrLocuri,s.NrLocuriVandute from Spectacole s JOIN Artisti a on s.IdArtist = a.IdArtist";

                using (var dataReader = command.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        int idArtist = dataReader.GetInt32(0);
                        string numeArtist = dataReader.GetString(1);
                        int idSpec = dataReader.GetInt32(2);
                        string dataSpec = dataReader.GetString(3);
                        string oraSpec= dataReader.GetString(4);
                        string locSpec = dataReader.GetString(5);
                        int nrLocuri = dataReader.GetInt32(6);
                        int nrLocuriVandute = dataReader.GetInt32(7);

                        Spectacol spec = new Spectacol(idSpec, new Artist(idArtist, numeArtist), dataSpec, oraSpec, locSpec, nrLocuri, nrLocuriVandute);
                        spectacole.Add(spec);
                    }
                }

            }

            return spectacole;
        }

        public Spectacol GetById(int idEntity)
        {
            return null;
        }

        public int Size()
        {
            return 0;
        }

        public void Update(int idEntity, Spectacol newEntity)
        {
            //throw new NotImplementedException();
        }

        public void UpdateNrLocuri(int idSpectacol, int nrLocuriVandute)
        {
            IDbConnection connection = DButils.getConnection(props);
            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "update Spectacole set NrLocuri=NrLocuri-@locVandute,NrLocuriVandute=NrLocuriVandute+@locVandute where IdSpectacol=@idSpec";
                var paramNrLocV = comm.CreateParameter();
                paramNrLocV.ParameterName = "@locVandute";
                paramNrLocV.Value = nrLocuriVandute;
                comm.Parameters.Add(paramNrLocV);

                var paramIdSpec = comm.CreateParameter();
                paramIdSpec.ParameterName = "@idSpec";
                paramIdSpec.Value = idSpectacol;
                comm.Parameters.Add(paramIdSpec);

                try
                {
                    comm.ExecuteNonQuery();
                    Console.WriteLine("update realizat");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }


        }
    }
}
