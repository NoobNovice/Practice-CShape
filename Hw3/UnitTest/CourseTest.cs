using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hw3;

namespace UnitTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void defaultConstructor()
        {
            Course c = new Course();
            Assert.AreEqual(c.Course_name, c.Lecturer, "TBA", "default constructor error");
            Assert.AreEqual(c.Course_id, "000000", "default constructor error");
            Assert.AreEqual(c.Max_students, 30, "default constructor error");
            Assert.AreEqual(c.No_students, 0, "default constructor error");
        }

        [TestMethod]
        public void parameterizedConstructor()
        {
            Course c = new Course("Web Programming", "269103", "Kenneth Cosh", 40);
            Assert.AreEqual(c.Course_name, "Web Programming", "parameterized constructor error");
            Assert.AreEqual(c.Course_id, "269103", "parameterized constructor error");
            Assert.AreEqual(c.Lecturer, "Kenneth Cosh", "parameterized constructor error");
            Assert.AreEqual(c.Max_students, 40, "parameterized constructor error");
            Assert.AreEqual(c.No_students, 0, "parameterized constructor error");
        }

        [TestMethod]
        public void validAttributes()
        {
            Course c = new Course("CPE200-OOP", "261344", "Pruet Boonma", 60);
            c.Course_id = "261200";
            c.Lecturer = c.Lecturer + " and Dome Potikanond";
            c.Max_students = 60;

            Assert.AreEqual(c.Course_id, "261200", "valid attributes error");
            Assert.AreEqual(c.Lecturer, "Pruet Boonma and Dome Potikanond", "valid attributes error");
            Assert.AreEqual(c.Max_students, 60, "valid attributes error");
        }

        [TestMethod]
        public void invalidAttributes()
        {
            Course c = new Course("CPE200-OOP", "261344", "Pruet Boonma", 60);
            c.Course_name = "";
            c.Course_id = "CPE200";
            c.Lecturer = "";
            c.Max_students = -10;

            Assert.AreEqual("CPE200-OOP", c.Course_name, "invalid attributes error");
            Assert.AreEqual("261344", c.Course_id, "invalid attributes error");
            Assert.AreEqual("Pruet Boonma", c.Lecturer, "invalid attributes error");
            Assert.AreEqual(60, c.Max_students, "invalid attributes error");

            c.Course_id = "2612003";
            Assert.AreEqual("261344", c.Course_id, "invalid attributes error");
            c.No_students = 80;
            Assert.AreEqual(0, c.No_students, "invalid attributes error");
            c.No_students = -3;
            Assert.AreEqual(0, c.No_students, "invalid attributes error");
        }

        [TestMethod]
        public void checkToStringNoStudent()
        {
            Course c = new Course("CPE200-OOP", "261344", "Pruet Boonma", 60);
            c.Lecturer = c.Lecturer + " and Dome Potikanond";
            c.Course_id = "261200";
            Assert.AreEqual("CPE200-OOP (261200), Teacher: Pruet Boonma and Dome Potikanond"
                 + ", has NO student, [maximum: 60]", c.ToString());
        }

        [TestMethod]
        public void checkToStringOneStudent()
        {
            Course c = new Course("CPE200-OOP", "261344", "Pruet Boonma", 60);
            c.No_students = 1;
            c.Course_id = "261200";
            c.Lecturer = c.Lecturer + " and Dome Potikanond";
            Assert.AreEqual("CPE200-OOP (261200), Teacher: Pruet Boonma and Dome Potikanond"
                 + ", has ONE student, [maximum: 60]", c.ToString());
        }

        [TestMethod]
        public void checkToStringManyStudent()
        {
            Course c = new Course("CPE200-OOP", "261344", "Pruet Boonma", 60);
            c.No_students = 45;
            c.Course_id = "261200";
            c.Lecturer = c.Lecturer + " and Dome Potikanond";
            Assert.AreEqual("CPE200-OOP (261200), Teacher: Pruet Boonma and Dome Potikanond"
                 + ", has 45 students, [maximum: 60]", c.ToString());
        }
    }
}
