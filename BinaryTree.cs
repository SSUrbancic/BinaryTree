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
    }
}
