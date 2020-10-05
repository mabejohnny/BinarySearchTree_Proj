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
            bool saveItem = false;

            if(root == null)
            {
                root = nodeToAdd; 
            }
            else
            { 
                Node currentNode = root;

                while (!saveItem)
                {
                    if (valueToInsert <= currentNode.data)
                    {
                        if(currentNode.left == null)
                        {
                            currentNode.left = nodeToAdd;
                            saveItem = true; 
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }      
                    }
                    else 
                    {
                        if(currentNode.right == null)
                        {
                            currentNode.right = nodeToAdd;
                            saveItem = true;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }

                }
              
            }
        }
    }
}
