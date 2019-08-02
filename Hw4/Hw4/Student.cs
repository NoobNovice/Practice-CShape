using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hw4
{
    public class Student
    {
        private string name = "John Doe";
        private string id = "560610000";
        private int year = 1990;
        private bool status = false;
        private List courses;
        public Student()
        {
            courses = new List();
        }

        public Student(string in_Name, string in_id)
        {
            courses = new List();
            if (isValidName(in_Name))
            {
                this.name = in_Name;
            }
            if (isValidStudent_id(in_id))
            {
                this.id = in_id;
            }
        }

        public Student(string in_Name, string in_id, int in_year)
        {
            courses = new List();
            if (isValidName(in_Name))
            {
                this.name = in_Name;
            }
            if (isValidStudent_id(in_id))
            {
                this.id = in_id;
            }
            if (isValidYOB(in_year))
            {
                this.year = in_year;
            }
        }

        public Student(string in_Name, string in_id, int in_year, bool in_status)
        {
            courses = new List();
            if (isValidName(in_Name))
            {
                this.name = in_Name;
            }
            if (isValidStudent_id(in_id))
            {
                this.id = in_id;
            }
            if (isValidYOB(in_year))
            {
                this.year = in_year;
            }
            this.status = in_status;
        }

        override
        public string ToString()
        {
            string o = this.name + " (" + this.id + ") was born in "
                    + this.year + " is an " + (this.status ? "ACTIVE" : "INACTIVE") + " student.";
            return o;
        }

        private bool isValidName(string name)
        {
            if (name == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isValidStudent_id(string id)
        {
            Regex id_pattern = new Regex(@"^[0-9][6-9][0-9][0-9][0-9][0-2][0-9][0-9][0-9]$");
            if (id_pattern.IsMatch(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isValidYOB(int yob)
        {
            if (yob <= 1989)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isActive()
        {
            return this.status;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (isValidName(value))
                {
                    name = value;
                }
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (isValidStudent_id(value))
                {
                    id = value;
                }
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (isValidYOB(value))
                {
                    year = value;
                }
            }
        }

        public bool AddCourse(Course c)
        {
            if (c.EnrollStudent(this))
            {
                courses.PushTotail(c);
                return true;
            }
            else
                return false;               // if unable to enroll a student
        }

        public bool DropCourse(Course c)
        {
            if (c.RemoveStudent(this))
            {
                courses.Remove(c);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
