using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonhardExercises
{
    public class Leonhard1to10Exercises
    {
        public static int Problem1(int limit)
        {
            int result = 0;
            if (limit>2)
            {
                for (int i = 1; i < limit; i++)
                {
                    if (i % 3==0 || i % 5 == 0)
                    {
                        result += i;
                    }
                }
            }
            return result;
        }

        //fibonacci
        public static int Problem2(int limit)
        {
            int t1 = 0;
            int t2 = 1;
            int next = 0;
            int result = 0;
            while (next < limit)
            {
                next = t1 + t2;
                t1 = t2;
                t2 = next;
                if (next % 2 == 0)
                    result += next;
            }
            return result;
        }

         
    }
}
