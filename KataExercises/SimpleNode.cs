using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises
{
    public class SimpleNode<T>
    {
        public T Value { get; }
        public SimpleNode<T> Next { get; internal set; }

        public SimpleNode(T value)
        {
            Value = value;
        }

        public void AddNode(T value)
        {
            var newNode = new SimpleNode<T>(value);
            var current = this;
            while(current.Next!=null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
}
