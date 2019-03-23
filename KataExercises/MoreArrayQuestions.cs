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

            for (int i = 0; i < value.Length - 1; i++)
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
            for (int i = 0; i < value.Length; i++)
            {
                var ascii = ((int)value[i]) - 65;
                if ((map & (1 << ascii)) > 0)
                {
                    return false;
                }
                map |= (1 << ascii);
            }
            return true;
        }

        public static bool IsPermutation(string string1, string string2)
        {
            if (string1.Length != string2.Length)
            {
                return false;
            }
            int[] map = new int[128];
            //Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < string1.Length; i++)
            {
                map[string1[i]] += 1;

            }
            for (int i = 0; i < string2.Length; i++)
            {
                map[string2[i]] -= 1;
                if (map[string2[i]] < 0)
                {
                    return false;
                }
            }
            for (int k = 0; k < map.Length; k++)
            {
                if (map[k] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static string Urlify(string value, int trueLength)
        {
            int spaces = 0;
            for (int k = 0; k < trueLength; k++)
            {
                if (value[k] == ' ')
                    spaces += 1;
            }


            var array = value.ToCharArray();
            //const string url_space = "%20";
            int j = trueLength + (spaces * 2);
            for (int i = trueLength - 1; i >= 0; i--)
            {
                var val = array[i];
                if (val != ' ')
                {
                    array[--j] = val;
                    //j -= 1;
                }
                else
                {
                    array[--j] = '0';
                    array[--j] = '2';
                    array[--j] = '%';
                    //j -= 3;
                }
            }
            return new string(array).Trim();
        }

        public static bool PalindromePermutation(string input)
        {
            input = input.ToLower();
            bool hasSingleChar = false;
            //if (input.Length % 2 == 0)
            //    hasSingleChar = true;
            int[] map = new int[26];
            int numSpaces=0;

            for (int i = 0; i < input.Length; i++)
            {
                var chr = ((int)input[i]) - 97;
                if (chr >= 0)
                {
                    map[chr] += 1;
                }
                else if (chr == -65)
                {
                    numSpaces += 1;
                }
                else
                {
                    throw new ArgumentException("${input} contained more than latters and a space");
                }
            }
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] % 2 != 0)
                {
                    if (hasSingleChar)
                    {
                        return false;
                    }
                    else
                    {
                        hasSingleChar = true;
                    }
                }
            }

            return true;
        }

        public static bool PalindromePermutationBitVector(string input)
        {
            input = input.ToLower();
            bool hasSingleChar = false;
            //if (input.Length % 2 == 0)
            //    hasSingleChar = true;
            int map = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var chr = ((int)input[i]) - 97;
                if ((map & 1 << chr) > 0)
                {
                    map &= ~(1 << chr);
                    //map |= (0 << chr);
                }else
                {
                    map |= (1 << chr);
                }
            }

            for (int j = 0; j < 31; j++) //32 bits in int
            {
                if((map & 1 << j) > 0)
                {
                    if (hasSingleChar)
                        return false;
                    hasSingleChar = true;
                }
            }
            return true;
        }

        public static bool OneAway(string value1, string value2)
        {
            value1 = value1.ToLower();
            value2 = value2.ToLower();
            var diff = Math.Abs(value1.Length - value2.Length);
            if (diff > 1)
                return false;

            int[] map = new int[128];
            for (int i = 0; i < value1.Length; i++)
            {
                map[(int)value1[i]]+= 1;
            }

            for (int i = 0; i < value2.Length; i++)
            {
                map[(int)value2[i]] -= 1;
                //if (map[(int)value2[i]] < -1)
                //    return false;
            }
            var changes = 0;
            for (int i = 0; i < map.Length; i++)
            {
                if (changes >2)
                    return false;
                changes += Math.Abs(map[i]);
            }
            return true;
        }

        public static void StringPermutations(string input)
        {
            StringPermutations("", input);
        }

        private static void StringPermutationsOld(string prefix,string input)
        {
            Console.WriteLine($"\t\t\t\t\t\t\t prefix: {prefix} input: {input}");
            int n = input.Length;
            if (n == 0)
            {
                Console.WriteLine(prefix);
               // return;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    StringPermutations(prefix + input[i], input.Substring(0, i) + input.Substring(i + 1));
                }
            }
        }

        private static void StringPermutations(string prefix, string input)
        {
            int n = input.Length;
            if (n == 0)
                Console.WriteLine(prefix);
            else
            {
                for (int i = 0; i < n; i++)
                {
                    string rem = input.Substring(0, i) + input.Substring(i + 1);
                    StringPermutations(prefix+ input[i], rem);
                }
            }
        }
               
        public static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        public static string StringCompression(string input)
        {
            if (input.Length < 3) return input;
            //Dictionary<char, int> map = new Dictionary<char, int>();
            StringBuilder sb = new StringBuilder();
            char previous = Char.MinValue;
            int charTotal = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (i == 0)
                {
                    charTotal = 1;
                    previous = current;
                }
                else
                {
                   
                    if (previous == current)
                    {
                        charTotal += 1;
                        previous = current;
                    }
                    else
                    {
                        sb.Append($"{previous}{charTotal}");
                        charTotal = 1;
                        previous = current;
                    }
                }
            }
            sb.Append($"{previous}{charTotal}");
            //return sb.ToString();
            return sb.ToString().Length > input.Length ? input : sb.ToString();
        }
    }
}
