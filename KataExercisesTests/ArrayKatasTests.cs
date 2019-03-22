using KataExercises;
using System;
using System.Linq;
using Xunit;

namespace KataExercisesTests
{
    public class ArrayKatasTests
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 2)]
        public void AreNumbersDivisibleByN(int[] values, int n)
        {
            var actual = ArrayKatas.NumbersDivisibleByN(values, n);
            var expected = new int[] { 2, 4, 6 };
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 2)]
        public void AreNumbersDivisibleByNCleaner(int[] values, int n)
        {
            var actual = ArrayKatas.NumbersDivisibleByNCleaner(values, n);
            var expected = new int[] { 2, 4, 6 };
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("7 1 3 2 4 5 6", "7 1")]
        [InlineData("1 2 3 4 5 6", "6 1")]
        [InlineData("1 2 2 -15 -6", "2 -15")]
        public void ReturnHighestAndLowestNumbers(string values, string expected)
        {
            var actual = ArrayKatas.HighestAndLowestNumbers(values);
             Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("7 1 3 2 4 5 6", "7 1")]
        [InlineData("1 2 3 4 5 6", "6 1")]
        [InlineData("1 2 2 -15 -6", "2 -15")]
        public void ReturnHighestAndLowestNumbersCleaner(string values, string expected)
        {
            var actual = ArrayKatas.HighestAndLowestNumbersCleaner(values);
            Assert.Equal(expected, actual);
        }

         [Theory]
         [InlineData(1,"1.00")]
         [InlineData(2, "1.25")]
         [InlineData(5, "1.57")]
        public void SeriesSum(int n, string expected)
        {
            var actual = ArrayKatas.SeriesSum(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "1.00")]
        [InlineData(2, "1.25")]
        [InlineData(5, "1.57")]
        public void SeriesSumCleaner(int n, string expected)
        {
            var actual = ArrayKatas.SeriesSumCleaner(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(999, 4)]
        [InlineData(39, 3)]
        [InlineData(4, 0)]
        public void Persistence(int n, int expected)
        {
            var actual = ArrayKatas.Persistence(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(999, 4)]
        [InlineData(39, 3)]
        [InlineData(4, 0)]
        public void PersistenceClean(int n, int expected)
        {
            var actual = ArrayKatas.PersistenceClean(n);
            Assert.Equal(expected, actual);
        }

        

    }
}
