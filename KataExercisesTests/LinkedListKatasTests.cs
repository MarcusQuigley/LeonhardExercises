using KataExercises;
using System;
using System.Linq;
using Xunit;

namespace KataExercisesTests
{
    public class LinkedListKatasTests
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 3,2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 3,3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 6)]
        public void FindKthElementTest(int[] values, int k, int expected)
        {
             var actual = LinkedListKatas<int>.FindKthElement(CreateList(values,4), k);
             Assert.Equal(expected, actual);
        }

        private static SimpleNode<int> CreateList(int[] vals, int first)
        {
            SimpleNode<int> node = new SimpleNode<int>(first);//,  });
            //int[] vals = new int[] { 3, 4, 7, 9, 7, 3, 1 };
            for (int i = 0; i < vals.Length; i++)
            {
                node.AddNode(vals[i]);
            }
            return node;
        }

    }
}
