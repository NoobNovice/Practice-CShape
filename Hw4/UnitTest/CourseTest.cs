using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hw4;

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

        [TestMethod]
        public void testEnrollRemoveStudent() 
        {
            Course c1 = new Course("C1","111111","L1", 3);
            Student s1 = new Student("S1", "590610701", 1991);
            Student s2 = new Student("S2", "590610702", 1992);
            Student s3 = new Student("S3", "590610703", 1993);
            Student s4 = new Student("S4", "590610704", 1994);

            Assert.IsTrue(c1.EnrollStudent(s1));
            Assert.IsFalse(c1.EnrollStudent(s1));
            Assert.IsTrue(c1.EnrollStudent(s2));
            Assert.IsTrue(c1.EnrollStudent(s3));
            Assert.IsFalse(c1.EnrollStudent(s4));

            Assert.IsTrue(c1.RemoveStudent(s2));
            Assert.IsFalse(c1.RemoveStudent(s2));
            Assert.IsTrue(c1.RemoveStudent(s3));
            Assert.IsFalse(c1.RemoveStudent(s4));
            Assert.IsTrue(c1.RemoveStudent(s1));
        }
    }
}
