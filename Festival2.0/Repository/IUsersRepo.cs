using Festival.Model;
using Festival.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival2._0.Repository
{
    interface IUsersRepo : RepoInterface<User>
    {
        Boolean exists(String userName, String pass);
    }
}
