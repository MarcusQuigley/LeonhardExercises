using System;

using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises
{
   public class LinkedListKatas<T>
    {

        public static LinkedList<int> RemoveDuplicatesBAD(LinkedList<int> list)
        {
            int[] array = new int[list.Count];
            var node = list.First;
       
            while(node!=null)
            {
                var value = node.Value;
                if(array[value]==0)
                {
                    array[value] = 1;
                }
                else //remove
                {
                    if (node.Previous == null) //its head
                    {
                      list.RemoveFirst();
                    } else if (node.Next == null)
                    {
                        list.RemoveLast();
                    }
                    else
                    {
                        list.Remove(node);
                    }
                }
                node = node.Next;
            }
            return list;
        }

        public static SimpleNode<T> RemoveDuplicates(SimpleNode<T> node)
        {
            var head = node;
            Dictionary<T, int> map = new Dictionary<T, int>();
            SimpleNode<T> previous = null;
            while(node!=null)
            {
                if (map.ContainsKey(node.Value))
                {
                    previous.Next = node.Next;
                }
                else
                {
                    map.Add(node.Value, 1);
                    previous = node;
                }

                node = node.Next;
            }
            return head;
        }

        public static SimpleNode<T> RemoveDuplicatesWithoutStorage(SimpleNode<T> node)
        {
            var head = node;
            SimpleNode<T> runner = null; 
            var previous = node;
            while(node!=null)
            {
                runner = node.Next;
                var pinnedValue = node.Value;
                while(runner!=null)
                {
                    if (runner.Value.Equals(pinnedValue))
                    {
                        previous.Next = runner.Next;
                    }
                    else
                    {
                        previous = runner;
                    }
                    runner = runner.Next;
                }
                node = node.Next;
            }
            return head;
        }

        public static T FindKthElement(SimpleNode<T> node, int kfromEnd) {
            var p1 = node;
            var p2 = node;
            for (int i = 0; i < kfromEnd; i++)
            {
                p1 = p1.Next;
                if (p1 == null) throw new Exception("not enough elements");
            }

            while (p1.Next!=null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }
            return p2.Value;
            
            //var head = node;
            //var counter = 0;
            //while(node!=null)
            //{
            //    counter += 1;
            //    node = node.Next;
            //}

            //int k = counter - kfromEnd;
            //counter = 0;
            //node = head;
            //while (node != null)
            //{
            //    counter += 1;
            //    if (counter == k)
            //    {
            //        return node.Value;
            //    }
            //    node = node.Next;
            //}
         //   return default(T);
        }
    }
}
