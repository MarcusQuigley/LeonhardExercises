using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises
{
    public class ArrayKatas
    {
        //Find numbers which are divisible by given number
        public static int[] NumbersDivisibleByN(int[] values, int n)
        {
            if (values == null) throw new ArgumentNullException("values");

            List<int> results = new List<int>();
            foreach (var item in values)
            {
                if (n% item == 0)
                {
                    results.Add(item);
                }
            }
            
            return results.ToArray();
        }

        //check if an array of integers contains two elements that sum to a given x
        public static void HasElementsThatSum(int[] values, int n)
        {


        }
    }
}
