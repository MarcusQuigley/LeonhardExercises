using System;
using System.Collections.Generic;
using System.Globalization;
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
                if (item % n == 0)
                {
                    results.Add(item);
                }
            }
            return results.ToArray();
        }

        public static int[] NumbersDivisibleByNCleaner(int[] values, int n)
        {
            if (values == null) throw new ArgumentNullException("values");
            return values.Where(v => v % n == 0).ToArray();
        }
        public static string HighestAndLowestNumbers(string values)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            var numberStrings = values.Split(' ');
            for (int i = 0; i < numberStrings.Length; i++)
            {
                var number = int.Parse(numberStrings[i]);
                if (i == 0)
                {
                    min = number;
                    max = number;
                }
                else
                {
                    if (number < min)
                    {
                        min = number;
                    }
                    else if (number > max)
                    {
                        max = number;
                    }
                }
            }

            return $"{max} {min}";
        }

        public static string HighestAndLowestNumbersCleaner(string values)
        {
            //  if (string.IsNullOrEmpty(values)) return new int[] { };
            var numbers = values.Split(' ')
                                .Select(s => int.Parse(s));
            return $"{numbers.Max()} {numbers.Min() }";
        }

        //check if an array of integers contains two elements that sum to a given x
        public static void HasElementsThatSum(int[] values, int n)
        {


        }

        //Sum of the first nth term of Series
        //Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +
        public static string SeriesSum(int n)
        {
            if (n == 0) return "0.00";
            double sum = 1.00;
            for (int i = 1; i < n; i++)
            {
                //var subSum = 1.0 / (i * 3 + 1);
                sum += 1.0 / (i * 3 + 1);
            }
            return sum.ToString("0.00", CultureInfo.InvariantCulture);
        }
        //return (from i in Enumerable.Range(0, n) select 1.0 / (3 * i + 1)).Sum().ToString("0.00");
        public static string SeriesSumCleaner(int n)
        {
            return Enumerable.Range(0, n)
                   .Select(i => 1f / (i * 3 + 1))
                   .Sum()
                   .ToString("0.00");
        }

        public static int Persistence(long n)
        {
            if (n.ToString().Length == 1) return 0;
            int result = 0;

            Stack<long> numbers = SplitNumbers(n);
            while (numbers.Count > 1)
            {
                long sum = 1;
                result += 1;
                foreach (var item in numbers)
                {
                    sum *= item;
                }
                numbers = SplitNumbers(sum);
            }
            return result;
        }

        static Stack<long> SplitNumbers(long n)
        {
            Stack<long> numbers = new Stack<long>();
            while (n > 0)
            {
                numbers.Push(n % 10);
                n = n / 10;
            }
            return numbers;
        }

        public static int PersistenceClean(long n)
        {
            int count = 0;
            while (n > 9)
            {
                count += 1;
                n = n.ToString()
                     .Select(digit => int.Parse(digit.ToString()))
                     .Aggregate((x, y) => x * y);
            }

            return count;
        }


         

        

        // given an array of integers where each element appears 
        //an even number of times and only one element appears 
        //an odd number of times, find the latter.

        
    }
}
