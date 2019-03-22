using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStudy
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable
    {
        private BinaryTreeNode<T> _root;
        private int _count;

        public int Count => _count;
      
        public void AddNode(T value)
        {
            if (_root == null)
            {
                _root = new BinaryTreeNode<T>(value);
            }
            else
            {

                //var compareResult = node.CompareTo(RootNode.Value);
                AddAChild(value, _root);
            }
            _count += 1;
        }

        void AddAChild(T value, BinaryTreeNode<T> nodeToCheck) {
            var compareResult = value.CompareTo(nodeToCheck.Value);
            if (compareResult < 0)
            {
                if (nodeToCheck.Left == null)
                {
                    nodeToCheck.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddAChild(value, nodeToCheck.Left);
                }
            }
            else //equal and > than will go right
            {
                if (nodeToCheck.Right == null)
                {
                    nodeToCheck.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddAChild(value, nodeToCheck.Right);
                }
            }
        }

        public bool Contains(T value)
        {
            BinaryTreeNode<T> parent;
            return FindNode(value, out parent)!=null;
        }

        BinaryTreeNode<T> FindNode(T value, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current = _root;
            parent = null;
            while (current != null)
            {
                int result = value.CompareTo(current.Value);
                if (result == 0)
                {
                    break;
                }
                parent = current;
                if (result < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return current;
            
        }

        public void Clear()
        {
            _root = null;
        }


        public bool Remove(T value)
        {
            BinaryTreeNode<T> parent = null;
            BinaryTreeNode<T> nodeToDelete = null;

            nodeToDelete = FindNode(value, out parent);
            if (nodeToDelete != null)
            {
              
                if (nodeToDelete.Right == null) //no right child
                {
                    if (parent == null)
                    {
                        _root = nodeToDelete.Left;
                    }
                    else if (nodeToDelete.Value.CompareTo(parent.Value) < 0)
                    {
                        parent.Left = nodeToDelete.Left;
                    }
                    else
                    {
                        parent.Right = nodeToDelete.Left;
                    }
                }
                else if (nodeToDelete.Right.Left == null) //right child has no left child
                {
                    nodeToDelete.Right.Left = nodeToDelete.Left;
                    if (parent == null)
                    {
                        _root = nodeToDelete.Right;

                    }
                    else if (nodeToDelete.Value.CompareTo(parent.Value) < 0)
                    {
                        parent.Left = nodeToDelete.Right;
                    }
                    else
                    {
                        parent.Right = nodeToDelete.Right;
                    }
                }
                else //right child has  left child
                {
                    BinaryTreeNode<T> leftist = nodeToDelete.Right.Left;
                    BinaryTreeNode<T> leftistParent = nodeToDelete.Right;

                    while(leftist.Left!=null)
                    {
                        leftistParent = leftist;
                        leftist = leftistParent.Left;
                    }
                    leftistParent.Left = leftist.Right;

                    leftist.Left = nodeToDelete.Left;
                    leftist.Right = nodeToDelete.Right;

                    if (parent==null) {
                        //var tempNode = nodeToDelete.Right.Left;
                        //nodeToDelete.Right.Left = tempNode.Left;
                        _root = leftist;
                    }
                    else if (nodeToDelete.Value.CompareTo(parent.Value) < 0)
                    {
                           parent.Left = leftist;
                    }
                    else
                    {
                        parent.Right = leftist;
                    }
                }
                _count -= 1;
 

            }
            return false;
        }

        public void PreOrderTraversal(Action<T> action)
        {
            PreOrderTraversal(_root, action);
        }

         void PreOrderTraversal(BinaryTreeNode<T> current, Action<T> action)
        {
            if (current == null) {
                return; }
            action(current.Value);
          //  DisplayValue(current.Value);
            PreOrderTraversal(current.Left, action);
            PreOrderTraversal(current.Right, action);
        }


        public void PostOrderTraversal(Action<T> action)
        {
            PostOrderTraversal(_root, action);
        }

        void PostOrderTraversal(BinaryTreeNode<T> current, Action<T> action)
        {
            if (current == null)
            {
                return;
            }
            PostOrderTraversal(current.Left, action);
            PostOrderTraversal(current.Right, action);
            action(current.Value);
        }
        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversal(_root, action);
        }

        void InOrderTraversal(BinaryTreeNode<T> current, Action<T> action)
        {

            if (current == null)
            {
                return;
            }
            InOrderTraversal(current.Left, action);
            action(current.Value);
            InOrderTraversal(current.Right, action);
        }
 

        public IEnumerator<T> InOrderTraversal()
        {
            bool goingLeft = true;
            BinaryTreeNode<T> current = _root;
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(current);
            while (stack.Count > 0)
            {
                if (goingLeft)
                {
                    while (current.Left != null)
                    {
                        stack.Push(current);
                        current = current.Left;
                    }
                }
                yield return current.Value;
                
                if (current.Right != null)
                {
                    current = current.Right;
                    goingLeft = true;
                }
                else
                {
                    current = stack.Pop();
                    goingLeft = false;
                }
            }

        }

        private void DisplayValue(T value)
        {
            Console.WriteLine(value);
        }
 

        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
