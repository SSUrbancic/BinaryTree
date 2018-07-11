using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.AddNode(50);
            binaryTree.AddNode(60);
            binaryTree.AddNode(45);
            binaryTree.AddNode(70);
            binaryTree.AddNode(100);
            binaryTree.AddNode(10);
            binaryTree.SearchForNode(70);
            binaryTree.SearchForNode(44);



            Console.ReadLine();
        }
    }
}
