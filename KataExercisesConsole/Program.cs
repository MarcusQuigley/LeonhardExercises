using KataExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercisesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestArrays();
            //TestLinkedList1();
            TestLinkedList2();
            Console.ReadKey();
        }

        static void TestArrays()
        {
            MoreArrayQuestions.StringPermutations("ab");
        }

        static void TestLinkedList1()
        {
            var list = CreateList(new int[] { 3, 4, 7, 9, 7, 3, 1 }, 4);
            DisplayList(list);
           var newList =  LinkedListKatas<int>.RemoveDuplicates(list);
            DisplayList(newList);

              list = CreateList(new int[] { }, 4);
            DisplayList(list);
              newList = LinkedListKatas<int>.RemoveDuplicates(list);
            DisplayList(newList);

              list = CreateList(new int[] { 3, 4, 7, 9, 7, 1, 1 }, 3);
            DisplayList(list);
              newList = LinkedListKatas<int>.RemoveDuplicates(list);
            DisplayList(newList);
        }

        static void TestLinkedList2()
        {
            var list = CreateList(new int[] { 3, 4, 7, 9, 7, 3, 1 }, 4);
            DisplayList(list);
            var newList = LinkedListKatas<int>.RemoveDuplicatesWithoutStorage(list);
            DisplayList(newList);

            list = CreateList(new int[] { }, 4);
            DisplayList(list);
            newList = LinkedListKatas<int>.RemoveDuplicates(list);
            DisplayList(newList);

            list = CreateList(new int[] { 3, 4, 7, 9, 7, 1, 1 }, 3);
            DisplayList(list);
            newList = LinkedListKatas<int>.RemoveDuplicates(list);
            DisplayList(newList);
        }

        private static SimpleNode<int> CreateList(int[] vals, int first )
        {
            SimpleNode<int> node = new SimpleNode<int>(first);//,  });
            //int[] vals = new int[] { 3, 4, 7, 9, 7, 3, 1 };
            for (int i = 0; i < vals.Length; i++)
            {
                node.AddNode(vals[i]);
            }
            return node;
        }

        private static void DisplayList(SimpleNode<int> node)
        {
            while (node != null)
            {
                Console.Write($"{node.Value} ");
                node = node.Next;
            }
            Console.WriteLine("-------------");
        }
    }
}
