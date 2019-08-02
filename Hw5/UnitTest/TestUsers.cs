using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hw5;

namespace UnitTest
{
    [TestClass]
    public class TestUsers
    {
        [TestMethod]
        public void AddUser()
        {
            Users userList = new Users();
            User u1 = new User();
            User u2 = new User();

            u1.UserName = "harrypotter";
            u1.Password = "HarryPotter1";
            u2.UserName = "hermionegranger";
            u2.Password = "HermioneGranger1";

            Assert.AreEqual(0, userList.Count());
            userList.AddUser(u1);
            Assert.AreEqual(1, userList.Count());
            userList.AddUser(u2);
            Assert.AreEqual(2, userList.Count());
        }

        [TestMethod]
        public void DeleteUser()
        {
            Users userList = new Users();
            User u1 = new User();
            User u2 = new User();

            u1.UserName = "harrypotter";
            u1.Password = "HarryPotter1";
            u2.UserName = "hermionegranger";
            u2.Password = "HermioneGranger1";

            Assert.AreEqual(0, userList.Count());
            userList.AddUser(u1);
            Assert.AreEqual(1, userList.Count());
            userList.AddUser(u2);
            Assert.AreEqual(2, userList.Count());

            userList.DeleteUser(u1);
            Assert.AreEqual(1, userList.Count());
            userList.DeleteUser(u2);
            Assert.AreEqual(0, userList.Count());

            try
            {
                userList.DeleteUser(u1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Error User name has not in List", ex.Message);
            }
        }

        [TestMethod]
        public void ExistsMethod()
        {
            Users userList = new Users();
            User u1 = new User();
            User u2 = new User();

            u1.UserName = "harrypotter";
            u1.Password = "HarryPotter1";
            u2.UserName = "hermionegranger";
            u2.Password = "HermioneGranger1";

            userList.AddUser(u1);
            Assert.IsTrue(userList.Exists(u1));
            Assert.IsFalse(userList.Exists(u2));
            userList.AddUser(u2);
            Assert.IsTrue(userList.Exists(u2));
            userList.DeleteUser(u1);
            Assert.IsFalse(userList.Exists(u1));
            userList.DeleteUser(u2);
            Assert.IsFalse(userList.Exists(u2));
        }

        [TestMethod]
        public void GetUserByUsername()
        {
            Users userList = new Users();
            User u1 = new User();
            User u2 = new User();

            u1.UserName = "harrypotter";
            u1.Password = "HarryPotter1";
            u2.UserName = "hermionegranger";
            u2.Password = "HermioneGranger1";

            userList.AddUser(u1);
            userList.AddUser(u2);
            Assert.AreEqual(u1, userList.GetUserByUsername(u1.UserName));
        }

        [TestMethod]
        public void GetUserArray()
        {
            Users userList = new Users();
            User u1 = new User();
            User u2 = new User();

            u1.UserName = "harrypotter";
            u1.Password = "HarryPotter1";
            u2.UserName = "hermionegranger";
            u2.Password = "HermioneGranger1";

            userList.AddUser(u1);
            userList.AddUser(u2);
            User []
            users = userList.GetUserArray();
            Assert.AreEqual(2, users.Length);
            Assert.IsTrue(users [0] == u1);
            Assert.IsTrue(users [1] == u2);
        }
    }   
}