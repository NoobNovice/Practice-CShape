using System;

namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hw1_1 hw1_1 = new Hw1_1();
            Hw1_2 hw1_2 = new Hw1_2();

            int[] numtest = {1,2,3,4,5,6,7,8,9};
            hw1_1.CountEvenNum(numtest);

            int[] credit = {3, 3, 3, 3, 2};
            int[] grade = {2, 4, 4, 3, 2};
            Console.WriteLine("your GPA is: {0:C}",hw1_2.CalculateGPA(credit,grade));
        }
    }
}
