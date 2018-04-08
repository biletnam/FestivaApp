using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Festival.Repository
{
    public static class DButils
    {
        private static IDbConnection instance = null;

        public static IDbConnection getConnection(IDictionary<string,string> props)
        {
            if (instance == null || instance.State == ConnectionState.Closed)
            {
                instance = getNewConnection(props);
                instance.Open();
            }
            return instance;
        }

        private static IDbConnection getNewConnection(IDictionary<string, string> props)
        {
            return SqlConnectionFactory.createConnection(props);
        }
    }
}
