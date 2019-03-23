using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStudy
{
    class DoubleLinkedListNode<T>
    {
        public T Value { get; }
        public DoubleLinkedListNode<T> Next { get; internal set; }
        public DoubleLinkedListNode<T> Previous { get; internal set; }

        public DoubleLinkedListNode(T value)
        {
            Value = value;
        }
    }
}
