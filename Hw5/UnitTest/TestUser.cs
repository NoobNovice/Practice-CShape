using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hw5;
namespace UnitTest
{
    [TestClass]
    public class TestUser
    {
        [TestMethod]
        public void SetUserNameValid()
        {
            User user = new User();
            user.UserName = "harrypotter";
            Assert.AreEqual(user.UserName, "harrypotter");
            user.UserName = "kinggeorge3";
            Assert.AreEqual(user.UserName, "kinggeorge3");
            user.UserName = "i5554321";
            Assert.AreEqual(user.UserName, "i5554321");
        }

        [TestMethod]
        public void SetUserNameInValid()
        {
            User user = new User();

            // shot user name
            try
            {
                user.UserName = "harry";
            }
            catch (Exception ex)
            {
                Assert.AreEqual("ERROR Invalid username", ex.Message);
            }

            // all number
            try
            {
                user.UserName = "15554321";
            }
            catch (Exception ex)
            {
                Assert.AreEqual("ERROR Invalid username", ex.Message);
            }

            // lead with number
            try
            {
                user.UserName = "5tormer5";
            }
            catch (Exception ex)
            {
                Assert.AreEqual("ERROR Invalid username", ex.Message);
            }

            // with symbol
            try
            {
                user.UserName = "harry-potter";
            }
            catch (Exception ex)
            {
                Assert.AreEqual("ERROR Invalid username", ex.Message);
            }
        }

        [TestMethod]
        public void SetPasswordValid()
        {
            User user = new User();
            user.Password = "A123456789012a";
            Assert.AreEqual("A123456789012a", user.Password);
            user.Password = "1Abcdefghijklmn";
            Assert.AreEqual("1Abcdefghijklmn", user.Password);
            user.Password = "Abcd12345abcd";
            Assert.AreEqual("Abcd12345abcd", user.Password);
        }

        [TestMethod]
        public void SetPasswordInvalid()
        {
            User user = new User();

            // short
            try
            {
                user.Password = "Abcd1";
            }
            catch (Exception ex)
            {
                Assert.AreEqual("ERROR Invalid password", ex.Message);
            }
            
            // no number
            try
            {
                user.Password = "Abcdefghtijk";
            }
            catch (Exception ex)
            {
                Assert.AreEqual("ERROR Invalid password", ex.Message);
            }

            // no capital
            try
            {
                user.Password = "abcdefghtijk123";
            }
            catch (Exception ex)
            {
                Assert.AreEqual("ERROR Invalid password", ex.Message);
            }

            // no small
            try
            {
                user.Password = "ABCDEFGHIJK123";
            }
            catch (Exception ex)
            {
                Assert.AreEqual("ERROR Invalid password", ex.Message);
            }
        }

        [TestMethod]
        public void GetUserName()
        {
            User user = new User();
            user.UserName = "harrypotter";
            Assert.AreEqual("harrypotter", user.UserName);
        }

        [TestMethod]
        public void GetPassword()
        {
            User user = new User();
            user.Password = "1Abcdefghijklmn";
            Assert.AreEqual("1Abcdefghijklmn", user.Password);
        }
    }
}
