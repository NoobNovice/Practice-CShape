using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hw6
{
    public abstract class IUser
    {
        private string userName = null;
        private string password;
        protected Regex name_pattern = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{7,}$");
        protected Regex pass_pattern = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*\d){12,}");

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (name_pattern.IsMatch(value))
                {
                    userName = value;
                }
                else
                {
                    throw new System.ArgumentException("ERROR Invalid username");
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (pass_pattern.IsMatch(value))
                {
                    password = value;
                }
                else
                {
                    throw new System.ArgumentException("ERROR Invalid password");
                }
            }
        }

        public abstract string PrintProfile();
    }
}
