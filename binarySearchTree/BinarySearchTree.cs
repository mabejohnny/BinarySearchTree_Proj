using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class BinarySearchTree
    {
        //Member Variables

        public Node root;

        //Constructor
        public BinarySearchTree()
        {
            root = null; 
        }

        //Member Methods

        public void Add(int valueToInsert)
        {
            Node nodeToAdd = new Node(valueToInsert);

            if(root == null)
            {
                root = nodeToAdd; 
            }
            else
            { 
                Node currentNode = root;

                if(currentNode.data < valueToInsert)
                {
                    while (true)
                    {
                        currentNode = currentNode.left;
                        currentNode.left = nodeToAdd;
                    }
                }
                else if(currentNode.data > valueToInsert)
                {
                    while (true)
                    {
                        currentNode = currentNode.right;
                        currentNode.right = nodeToAdd;
                    }
                }
              
            }
        }
    }
}
