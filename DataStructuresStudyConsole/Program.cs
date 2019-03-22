using DataStructuresStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStudyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBinaryTree();
            Console.ReadKey();
        }

        static void TestBinaryTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.AddNode(4);
            tree.AddNode(6);
            tree.AddNode(2);
            tree.AddNode(7);
            tree.AddNode(3);
            tree.AddNode(5);
            tree.AddNode(1);
            tree.PreOrderTraversal(DisplayValueLine);
            Console.WriteLine($"HAve we a 4? {tree.Contains(4)}");
            Console.WriteLine($"HAve we a 14? {tree.Contains(14)}");
            Console.WriteLine($"HAve we a 20? {tree.Contains(2)}");
            tree.InOrderTraversal(DisplayValueLine);
            Console.WriteLine();
            
            tree.PostOrderTraversal(DisplayValueLine);
            Console.WriteLine("------");
           // var enumerator = tree.InOrderTraversal();
            foreach (var item in tree)
            {
                DisplayValueLine(item);
            }

        }

        static void DisplayValueLine(int value)
        {
            Console.Write(value + " ");
        }

        static void DisplayValue(int value)
        {
            Console.WriteLine(value);
        }
    }
}
