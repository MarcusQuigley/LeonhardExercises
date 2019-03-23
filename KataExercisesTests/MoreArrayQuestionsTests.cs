//using KataExercises;
//using System;
//using System.Linq;
//using Xunit;

//namespace KataExercisesTests
//{
//    public class MoreArrayQuestionsTests
//    {
//        [Theory]
//        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 16, false)]
//        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 8, true)]
//        public void FindSumBrutes(int[] values, int n, bool expected)
//        {
//            var actual = MoreArrayQuestions.FindSum2(values, n);

//            Assert.Equal(expected, actual);
//        }
   
//        [Theory]
//        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 16, false)]
//        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 8, true)]
//        public void FindSum3(int[] values, int n, bool expected)
//        {
//            var actual = MoreArrayQuestions.FindSum3(values, n);

//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData("InlineData", false)]
//        [InlineData("zeromatix", true)]
//        public void IsUniqueString(string value,  bool expected)
//        {
//            var actual = MoreArrayQuestions.IsUniqueString(value);

//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData("InlineData", false)]
//        [InlineData("zeromatix", true)]
//        public void IsUniqueStringBetter(string value, bool expected)
//        {
//            var actual = MoreArrayQuestions.IsUniqueStringBetter(value);

//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData("god","dog", true)]
//        [InlineData("JEsus", "Christ", false)]
//        [InlineData("cat", "tab", false)]
//        public void IsPermutationTest(string value1, string value2, bool expected)
//        {
//            var actual = MoreArrayQuestions.IsPermutation(value1, value2);
//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData("Mr John Smith      ", 13, "Mr%20John%20Smith")]
//        public void UrlifyTest(string value1, int trueLength, string expected)
//        {
//            var actual = MoreArrayQuestions.Urlify(value1, trueLength);
//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData("Tact Cao",  true)]
//        //[InlineData("JEsus", "Christ", false)]
         
//        public void PalindromePermutationTest(string value,  bool expected)
//        {
//            var actual = MoreArrayQuestions.PalindromePermutation(value);
//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData("Tact Cao", true)]
//        //[InlineData("JEsus", "Christ", false)]

//        public void PalindromePermutationBitVectorTest(string value, bool expected)
//        {
//            var actual = MoreArrayQuestions.PalindromePermutationBitVector(value);
//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData("pale", "ple", true)]
//        [InlineData("palew", "pale", true)]
//        [InlineData("pale", "bale", true)]
//        [InlineData("pale", "bake", false)]

//        public void OneAwayTest(string value1, string value2, bool expected)
//        {
//            var actual = MoreArrayQuestions.OneAway(value1,value2);
//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData(3,6)]
//        [InlineData(4,24)]
//        [InlineData(1,1)]
//        [InlineData(6,720)]
//         public void FactorialTest(int value1, int expected)
//        {
//            var actual = MoreArrayQuestions.Factorial(value1);
//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData("aabcccccaaa","a2b1c5a3")]
//        [InlineData("aabcccccd", "a2b1c5d1")]
//        [InlineData("aabc", "aabc")]
//        public void StringCompressionTest(string input, string expected)
//        {
//            var actual = MoreArrayQuestions.StringCompression(input);
//            Assert.Equal(expected, actual);
//        }


//    }
//}
