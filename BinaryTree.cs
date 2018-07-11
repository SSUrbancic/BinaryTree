using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree<T>
    {
        //Members(HAS A)
        Node<T> rootNode;
        int count;

        //Constructor
        public BinaryTree()
        {
            rootNode = null;
            count = 0;
        }
        public void SetRootNode(T nodeValue)
        {
            if (rootNode == null)
            {
                rootNode = new Node<T>(nodeValue);
                count++;
            }
        }
        public void AddNode(T nodeValue)
        {
            SetRootNode(nodeValue);
            Node<T> temporaryNode = rootNode;
            while (true)
            {
                if (Comparer<T>.Default.Compare(nodeValue, temporaryNode.value) < 0)
                {
                    if (temporaryNode.leftChild == null)
                    {
                        temporaryNode.leftChild = new Node<T>(nodeValue);
                        count++;
                        break;
                    }
                    temporaryNode = temporaryNode.leftChild;
                }
                else if (Comparer<T>.Default.Compare(nodeValue, temporaryNode.value) >= 0)
                {
                    if (temporaryNode.rightChild == null)
                    {
                        temporaryNode.rightChild = new Node<T>(nodeValue);
                        count++;
                        break;
                    }
                    temporaryNode = temporaryNode.rightChild;
                }
            }
        }
        public Node<T> SearchForNode(T value)
        {
            Node<T> temporaryNode = rootNode;
            while (true)
            {
                if (temporaryNode.leftChild == null && temporaryNode.rightChild == null)
                {
                    Console.WriteLine("This node doesn't exist in this Binary Tree, pLease try another value.");
                    return null;
                }
                if (temporaryNode.value.Equals(value))
                {
                    return temporaryNode;
                }
                if (Comparer<T>.Default.Compare(value, temporaryNode.value) < 0)
                {
                    if (temporaryNode.leftChild.value.Equals(value))
                    {
                        Console.WriteLine($"Found: {temporaryNode.leftChild.value}");
                        return temporaryNode.leftChild;
                    }
                    Console.WriteLine("Left");
                    temporaryNode = temporaryNode.leftChild;
                }
                else if (Comparer<T>.Default.Compare(value, temporaryNode.value) >= 0)
                {
                    if (temporaryNode.rightChild.value.Equals(value))
                    {
                        Console.WriteLine($"Found: {temporaryNode.rightChild.value}");
                        return temporaryNode.rightChild;
                    }
                    Console.WriteLine("Right");
                    temporaryNode = temporaryNode.rightChild;
                }
            }
        }
    }
}

