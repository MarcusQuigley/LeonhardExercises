using KataExercises;
using System;
using System.Linq;
using Xunit;

namespace KataExercisesTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 2)]
        public void AreNumbersDivisibleByN(int[] values, int n)
        {
            var actual = ArrayKatas.NumbersDivisibleByN(values, n);
            var expected = new int[] { 2, 4, 6 };
            Assert.Equal(expected, actual);
        }
    }
}
