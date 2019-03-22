using KataExercises;
using System;
using System.Linq;
using Xunit;

namespace KataExercisesTests
{
    public class MoreArrayQuestionsTests
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 16, false)]
        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 8, true)]
        public void FindSumBrutes(int[] values, int n, bool expected)
        {
            var actual = MoreArrayQuestions.FindSum2(values, n);

            Assert.Equal(expected, actual);
        }
   
        [Theory]
        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 16, false)]
        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 8, true)]
        public void FindSum3(int[] values, int n, bool expected)
        {
            var actual = MoreArrayQuestions.FindSum3(values, n);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("InlineData", false)]
        [InlineData("zeromatix", true)]
        public void IsUniqueString(string value,  bool expected)
        {
            var actual = MoreArrayQuestions.IsUniqueString(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("InlineData", false)]
        [InlineData("zeromatix", true)]
        public void IsUniqueStringBetter(string value, bool expected)
        {
            var actual = MoreArrayQuestions.IsUniqueStringBetter(value);

            Assert.Equal(expected, actual);
        }
    }
}
