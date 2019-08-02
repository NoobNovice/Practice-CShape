using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[10];

            Console.WriteLine("******** All students ********");
            for (int i = 1; i < 9; i++)
            {
                // Student s[0] will not be used.
                s[i] = new Student("S" + i.ToString(), "58061170" + i.ToString(), 1990 + (i));
                Console.WriteLine(s[i]);
            }

            Console.WriteLine("\n******** Available courses ********");
            Course cpe102 = new Course("Computer Programming", "261102", "Santi");
            Course cpe200 = new Course("Object Oriented Programming", "261200", "Dome");
            Course isne103 = new Course("Programming for ISNE", "269103", "Patiwet", 10);
            Course isne200 = new Course("Web Programming", "269200", "Kenneth", 10);
            Course isne202 = new Course("Algorithm for ISNE", "269202", "Kenneth", 10);

            Console.WriteLine(cpe102);
            Console.WriteLine(cpe200);
            Console.WriteLine(isne103);
            Console.WriteLine(isne200);
            Console.WriteLine(isne202);


            Console.WriteLine("\n******** Start batch enrollment: ADD transactions ********");
            s[1].AddCourse(cpe102); s[1].AddCourse(cpe102); s[1].AddCourse(cpe200); s[1].AddCourse(isne103); s[1].AddCourse(isne200);
            s[2].AddCourse(cpe102); s[2].AddCourse(cpe200); s[2].AddCourse(isne103); s[2].AddCourse(isne202);
            s[3].AddCourse(cpe102); s[3].AddCourse(isne103); s[3].AddCourse(isne200); s[3].AddCourse(isne202);
            s[4].AddCourse(cpe102); s[4].AddCourse(isne202);
            s[5].AddCourse(isne202); s[5].AddCourse(isne200);
            s[6].AddCourse(isne202);
            s[7].AddCourse(isne202);
            s[8].AddCourse(isne202);


            Console.WriteLine("\n******** After ADD transactions ********");
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine(cpe102);
            Console.WriteLine(cpe200);
            Console.WriteLine(isne103);
            Console.WriteLine(isne200);
            Console.WriteLine(isne202);

            Console.WriteLine("\n******** Start batch enrollment: DROP transactions ********");
            Console.WriteLine(cpe102);
            Console.WriteLine(isne200);
            Console.WriteLine(isne103);
            s[3].DropCourse(cpe200); s[3].DropCourse(cpe102);
            s[8].DropCourse(isne202); s[8].DropCourse(cpe200);

            Console.WriteLine("\n******** After DROP transactions ********");
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine(cpe102);
            Console.WriteLine(cpe200);
            Console.WriteLine(isne103);
            Console.WriteLine(isne200);
            Console.WriteLine(isne202);
            Console.ReadLine();
        }
    }
}
