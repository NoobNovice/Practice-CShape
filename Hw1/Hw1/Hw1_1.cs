using System;
using System.Collections.Generic;
using System.Text;

namespace Hw1
{
    class Hw1_1
    {
        public Hw1_1()
        {

        }

        public void CountEvenNum(int[] num)
        {
            int even = 0;
            foreach(int v in num)
            {
                if (v % 2 == 0)
                {
                    even++;
                }
            }
            Console.WriteLine("Even is: "+even.ToString());
        }

    }
}
