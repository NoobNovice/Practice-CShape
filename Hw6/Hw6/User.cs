using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hw6
{
    public class User : IUser
    {
        public User()
        {

        }

        public User(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }

        public override string PrintProfile()
        {
            return "username: " + UserName + "/n" + "password: " + Password;
        }
    }
}
