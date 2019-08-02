using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hw3
{
    public class Course
    {
        //// Regular expression for the Student ID pattern
        //private static final String idREGEX = "\\d{6}";

        // all private attributes
        private string course_name = "TBA";
        private string course_id = "000000";
        private string lecturer = "TBA";
        private int max_students = 30;
        private int no_students = 0;
        public Course()
        {

        }

        public Course(string course_name, string course_id)
        {
            this.course_name = course_name;
            this.course_id = course_id;
        }

        public Course(string course_name, string course_id, string lecturer)
        {
            this.course_name = course_name;
            this.course_id = course_id;
            this.lecturer = lecturer;
        }

        public Course(string course_name, string course_id, string lecturer, int max_students)
        {
            this.course_name = course_name;
            this.course_id = course_id;
            this.lecturer = lecturer;
            this.max_students = max_students;
        }

        public string Course_name
        {
            get
            {
                return course_name;
            }
            set
            {
                if(value != "")
                {
                    course_name = value;
                }
            }
        }

        public string Course_id
        {
            get
            {
                return course_id;
            }
            set
            {
                Regex id_pattern = new Regex(@"^\d{1,6}$");
                if (id_pattern.IsMatch(value))
                {
                    course_id = value;
                }
            }
        }

        public string Lecturer
        {
            get
            {
                return lecturer;
            }
            set
            {
                if (value != "")
                {
                    lecturer = value;
                }
            }
        }

        public int Max_students
        {
            get
            {
                return max_students;
            }
            set
            {
                if (value >= 10)
                {
                    max_students = value;
                }
            }
        }

        public int No_students
        {
            get
            {
                return no_students;
            }
            set
            {
                if (0 <= value && value <= max_students)
                {
                    no_students = value;
                }
            }
        }

        override
        public string ToString()
        {
            string sender = course_name + " ("
                + course_id + "), Teacher: "
                + lecturer + ", has " + ((no_students == 0) ? "NO student" : (no_students > 2) ?
                no_students + " students" : "ONE student") + ", "
                + "[maximum: " + max_students + "]";
            return sender;
        }
    }
}
