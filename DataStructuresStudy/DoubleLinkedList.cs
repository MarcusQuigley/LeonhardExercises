using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStudy
{
    public class DoubleLinkedList<T> : ICollection<T>
    {
        private int _count;
        private DoubleLinkedListNode<T> _head;
        private DoubleLinkedListNode<T> _tail;


        public int Count =>   _count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void AddFirst(T item)
        {
            DoubleLinkedListNode<T> node = new DoubleLinkedListNode<T>(item);
            DoubleLinkedListNode<T> temp = _head;

            _head = node;
            _head.Next = temp;

            if (temp == null)
            {
                 _tail = _head;
            }
            else
            {
                //node.Next = _head;
                temp.Previous = _head;                  
            }
            _count++;
        }

        public void AddLast(T item)
        {
            Add(item);
        }


        public void Add(T item)
        {
            DoubleLinkedListNode<T> nodeToAdd = new DoubleLinkedListNode<T>(item);
            if (_head==null)
            {
                _head = nodeToAdd;
                _tail = _head;
            }
            else
            {
                var current = _head;
                while(current.Next!=null)
                {
                    current = current.Next;
                }
                current.Next = nodeToAdd;
                _tail = current.Next;
            }
            _count++;
        }

        public void Clear()
        {
            _head = null;
            _tail = _head;
            _count = 0;
        }

        public bool Contains(T item)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while(current!=null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            DoubleLinkedListNode<T> current = _head;
            DoubleLinkedListNode<T> previous = null;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            _tail = null;
                        _count -= 1;
                    }
                    else //head
                    {
                        if (current.Next == null)
                        {
                            Clear();
                        }
                        else
                        {
                            _head = current.Next;
                            _count -= 1;
                        }
                    }
                }
                previous = current;
                current = current.Next;

            }
            return false;
        }

        public void RemoveFirst(T item)
        {
            if (Count > 0)
            {
                _head = _head.Next;
                _count--;
                if (_count == 0)
                {

                    _tail = null;
                }
                else
                    _head.Previous = null;
            }
            

        }

        public void RemoveLast(T item)
        {
            if (Count > 0)
            {
                if (Count == 1)
                {
                    _tail = null;
                    _head =null;
                }
                else
                {
                    _tail = _tail.Previous;
                    _tail.Next = null;
                }
                _count--;
            }
             
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
