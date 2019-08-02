using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6
{
    public class Users
    {
        private ArrayList userList;

        public Users()
        {
            userList = new ArrayList();
        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public void AddUser(string userName, string password)
        {
            User temp = new User(userName, password);
            userList.Add(temp);
        }

        public void DeleteUser(User user)
        {
            if (!Exists(user) || userList.Count == 0)
            {
                throw new System.NullReferenceException("Error User name has not in List");
            }

            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i] == user)
                {
                    userList.RemoveAt(i);
                }
            }
        }

        public bool Exists(User user)
        {
            foreach (User u in userList)
            {
                if (u == user)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UsernameExists(string username)
        {
            foreach (User u in userList)
            {
                if (u.UserName == username)
                {
                    return true;
                }
            }
            return false;
        }

        /* This method should return null when the user with username is not in the list */
        public User GetUserByUsername(string username)
        {
            foreach (User u in userList)
            {
                if (u.UserName == username)
                {
                    return u;
                }
            }
            return null;
        }

        public int Count()
        {
            return userList.Count;
        }

        public User[] GetUserArray()
        {
            return userList.ToArray(typeof(User)) as User[];
        }
    }
}
