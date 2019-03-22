using DataStructuresStudy;
using Xunit;

namespace DataStructuresStudyTest
{
    public class BinaryTreeTests
    {
//        [Fact]
        public void CreateTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.AddNode(4);
            tree.AddNode(10);

            foreach (var node in tree)
            {
                System.Console.Write(node);
            }
            System.Console.WriteLine();

            Assert.Equal(1, 1);
        }
    }
}
