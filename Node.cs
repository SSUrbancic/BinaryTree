using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T>
    {
        //Members
        public Node<T> rightChild;
        public Node<T> leftChild;

        public T value;

        //Constructor
        public Node(T nodeValue)
        {
            value = nodeValue;
            rightChild = null;
            leftChild = null;
        }
        //Methods(CAN DO)
    }
}
