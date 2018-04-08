using Festival.Repository;
using Festival2._0.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festival2._0
{
    static class Program
    {

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Console.WriteLine("Configuration Settings for Festival {0}", GetConnectionStringByName("Festival"));
            IDictionary<string, string> props = new SortedList<string, string>();
            props.Add("ConnectionString", GetConnectionStringByName("Festival"));

            UsersRepo usersRepo = new UsersRepo(props);

            BileteRepo bileteRepo = new BileteRepo(props);
            ClientiRepo ClientiRepo = new ClientiRepo(props);
            SpectacoleRepo SpectacoleRepo = new SpectacoleRepo(props);

            ServiceUsers servUsers = new ServiceUsers(usersRepo);
            ServiceClienti servClienti = new ServiceClienti(ClientiRepo);
            ServiceSpectacole servSpec = new ServiceSpectacole(SpectacoleRepo);
            ServiceBilete servBilete = new ServiceBilete(bileteRepo, servClienti, servSpec);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn(servUsers,servBilete,servClienti,servSpec));
        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
