using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStudy
{
    public class LinkedList<T> : ICollection<T>
    {
        private int _count;
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _tail;


        public int Count =>   _count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            LinkedListNode<T> nodeToAdd = new LinkedListNode<T>(item);
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
            LinkedListNode<T> _node = _head;
            while (_node != null)
            {
                yield return _node.Value;
                _node = _node.Next;
            }
        }

        //public bool Remove(T item)
        //{
        //    var current = _head;

        //    if (current.Value.Equals(item){
        //        Clear();
        //    }
        //    else {
        //        while (current.Next != null)
        //        {
        //            if (current.Next.Value.Equals(item))
        //            {

        //                var tmp = current.Next.Next;
        //                current.Next = tmp;
        //                _count--;
        //                if (_tail.Value.Equals(tmp.Value))
        //                {
        //                    _tail = current.Next;
        //                }

        //                return true;
        //            }
        //            current = current.Next;
        //        }
        //    }
        //    return false;
        //}

        public bool Remove(T item)
        {
            LinkedListNode<T> current = _head;
            LinkedListNode<T> previous=null;
            while(current!=null)
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
                        if (current.Next==null)
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

       

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
