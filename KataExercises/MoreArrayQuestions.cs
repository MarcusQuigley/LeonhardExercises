using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises
{
    public class MoreArrayQuestions
    {
        public static bool FindSum2(int[] values, int n)
        {//O(n) sq for time
            Array.Sort(values);
            for (int i = 0; i < values.Length; i++)
            {
                var value = values[i];
                if (n % value == 0)
                {
                    var divisor = n / value;
                    for (int j = i + 1; j < values.Length; j++)
                    {
                        var valueJ = values[j];
                        if (valueJ == divisor)
                            return true;
                        if (valueJ > divisor)
                        {
                            break;
                        }
                    }
                }
            }
            return false;
        }
        public static bool FindSum3(int[] values, int n)
        {//O(n) sq for time
            Array.Sort(values);
            int start = 0;
            int end = values.Length - 1;
            while (start < end)
            {
                var sum = values[start] + values[end];
                if (sum == n)
                    return true;
                if (sum > n)
                {
                    end -= 1;
                }
                else
                {
                    start += 1;
                }
            }
            return false;
        }
 
        public static bool IsUniqueString(string value)
        {
            if (value.Length > 128)
                return false;
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < value.Length-1; i++)
            {
                char chr = value[i];
                //if (map[chr] != 0)
                if (map.ContainsKey(chr))
                {
                    return false;
                }
                map[chr] = 1;
            }
            return true;
        }
        //Were only presuming value is lowercase
        public static bool IsUniqueStringBetter(string value)
        {
            value = value.ToLower();
            if (value.Length > 26)
            {
                return false;
            }

            int map = 0;
            for(int i=0;i<value.Length;i++)
            {
                var ascii = ((int)value[i]) -65;
                if ((map & (1 << ascii)) > 0)
                {
                    return false;
                }
                map |= (1 << ascii);
            }
            return true;
        }

    }
}
