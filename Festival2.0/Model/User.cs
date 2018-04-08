using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Model
{
    public class User
    {
        public String UserName { get; set; }
        public String Password { get; set; }

        public User(String userName, String pass)
        {
            this.UserName = userName;
            this.Password = pass;
        }

        public override string ToString()
        {
            return "User{" +
                "UserName='" + UserName + '\'' +
                ", Password='" + Password + '\'' +
                '}';
        }

    }
}
