using Festival.Model;
using Festival2._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Festival.Repository
{
    public class ClientiRepo : IClientiRepo
    {
        IDictionary<string, string> props;

        public ClientiRepo(IDictionary<string,string> props)
        {
            this.props = props;
        }

        public void Add(Client entity)
        {
            var connection = DButils.getConnection(props);

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "insert into Clienti(IdClient,Nume) values(@idClient,@nume)";
                var idClient = comm.CreateParameter();
                idClient.ParameterName = "@idClient";
                idClient.Value = entity.IdClient;
                comm.Parameters.Add(idClient);

                var numeC = comm.CreateParameter();
                numeC.ParameterName = "@nume";
                numeC.Value = entity.Nume;
                comm.Parameters.Add(numeC);

                try
                {
                    comm.ExecuteNonQuery();
                    Console.WriteLine("Adaugare efectuata!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Eroare adaugare " + e.Message);
                }

            }

        }

        public void Delete(int idEntity)
        {
            //throw new NotImplementedException();
        }

        public ICollection<Client> GetAll()
        {
            return null;
        }

        public Client GetById(int idEntity)
        {
            return null;
        }

        public int Size()
        {
            //throw new NotImplementedException();
            return 0;
        }

        public void Update(int idEntity, Client newEntity)
        {
            //throw new NotImplementedException();
           
        }
    }
}
