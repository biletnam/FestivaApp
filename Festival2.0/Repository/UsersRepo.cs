using Festival.Model;
using Festival2._0.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Repository
{
    public class UsersRepo : IUsersRepo
    {
        IDictionary<string, string> props;

        public UsersRepo(IDictionary<string,string> props)
        {
            this.props = props;
        }

        public void Add(User entity)
        {
           // throw new NotImplementedException();
        }

        public void Delete(int idEntity)
        {
            //throw new NotImplementedException();
        }

        public ICollection<User> GetAll()
        {
            return null;
        }

        public User GetById(int idEntity)
        {
            return null;
        }

        public int Size()
        {
            return 0;
        }

        public void Update(int idEntity, User newEntity)
        {
            //throw new NotImplementedException();
        }

        public Boolean exists(String userName, String pass)
        {
             IDbConnection connection = DButils.getConnection(props); 

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select Count(*) as Existance from Useri where UserName = @user and Password = @pass";
                IDbDataParameter param = command.CreateParameter();
                param.ParameterName = "@user";
                param.Value = userName;
                command.Parameters.Add(param);

                IDbDataParameter password = command.CreateParameter();
                password.ParameterName = "@pass";
                password.Value = pass;
                command.Parameters.Add(password);

                using (var dataReader = command.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        int existance = dataReader.GetInt16(0);
                        if (existance != 0)
                            return true;
                    }
                }
            }

            return false;

        }
    }
}
