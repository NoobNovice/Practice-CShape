using System;
using System.Collections.Generic;
using System.Text;

namespace Hw1
{
    class Hw1_2
    {
        public Hw1_2()
        {

        }

        public float CalculateGPA(int[] credit,int[] grade)
        {
            float sum = 0;
            float sumc = 0;
            for(int i = 0; i < credit.Length; i++)
            {
                sum += credit[i] * grade[i] * 1.0f;
                sumc += credit[i] * 1.0f;
            }
            return sum / sumc;
        }
    }
}
