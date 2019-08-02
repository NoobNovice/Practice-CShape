using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hw4;

namespace UnitTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void defaultConstructor()
        {
            Student s = new Student();
            Assert.AreEqual("John Doe", s.Name);
            Assert.AreEqual("560610000", s.Id);
            Assert.AreEqual(1990, s.Year);
            Assert.AreEqual(false, s.isActive());
        }

        [TestMethod]
        public void parameterizedConstructor()
        {
            // valid data
            Student s = new Student("Saman Boonme", "590613001", 1998, true);
            Assert.AreEqual("Saman Boonme", s.Name);
            Assert.AreEqual("560610000", s.Id);
            Assert.AreEqual(1998, s.Year);
            Assert.AreEqual(true, s.isActive());

            // invalid data
            s = new Student("Somchai Maakmee", "500611701", 1980, false);
            Assert.AreEqual("Somchai Maakmee", s.Name);
            Assert.AreEqual("560610000", s.Id);
            Assert.AreEqual(1990, s.Year);
            Assert.AreEqual(false, s.isActive());
        }

        [TestMethod]
        public void invalidName()
        {
            Student s = new Student("Sanguan Sornjai", "590611702", 1999, false);

            s.Name = "";
            Assert.AreEqual("Sanguan Sornjai", s.Name);
        }

        [TestMethod]
        public void invalidStudentID()
        {
            Student s = new Student("Sanguan Sornjai", "590611702", 1999, false);

            // invalid data
            s.Id = "550710111";
            Assert.AreEqual("590611702", s.Id);

            // valid data
            s.Id = "590612111";
            Assert.AreEqual("590612111", s.Id);

            // invalid data
            s.Id = "590613111";
            Assert.AreEqual("590612111", s.Id);

            // invalid data
            s.Id = "590613111000";
            Assert.AreEqual("590612111", s.Id);

            // invalid data
            s.Id = "helloworld";
            Assert.AreEqual("590612111", s.Id);
        }

        [TestMethod]
        public void invalidYOB()
        {
            Student s = new Student("Sanguan Sornjai", "590611702", 1999, false);
            s.Year = 1976;
            Assert.AreEqual(1999, s.Year);
        }

        [TestMethod]
        public void checkToString()
        {
            Student s = new Student("Sanguan Sornjai", "590611702", 1999, false);

            Assert.AreEqual("Sanguan Sornjai (590611702) was born in 1999 is an INACTIVE student.", s.ToString());
        }

        [TestMethod]
        public void testAddDropCourse()
        {
            Student s1 = new Student("S1","590610701",1995);
            Course c1 = new Course("C1", "111111", "L1");
            Course c2 = new Course("C2", "222222", "L2");
            Course c3 = new Course("C3", "333333", "L3");

            Assert.IsTrue(s1.AddCourse(c1));
            Assert.IsTrue(s1.AddCourse(c2));
            Assert.IsTrue(s1.AddCourse(c3));
            Assert.IsFalse(s1.AddCourse(c1));
            Assert.IsFalse(s1.AddCourse(c2));

            Assert.IsTrue(s1.DropCourse(c2));
            Assert.IsTrue(s1.DropCourse(c1));
            Assert.IsTrue(s1.DropCourse(c3));
            Assert.IsFalse(s1.DropCourse(c1));
            Assert.IsFalse(s1.DropCourse(c2));
        }
    }
}
