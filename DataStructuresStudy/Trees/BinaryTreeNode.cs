using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStudy
{
    public class BinaryTreeNode<T> : IComparable<T> where T : IComparable
    {
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        public T Value { get;  }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }

        public static bool IsLeafNode(BinaryTreeNode<T> node)
        {
            return node.Left == null && node.Right == null;
        }
    }
}
