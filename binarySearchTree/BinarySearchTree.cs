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

        //first check if value equals root, if so return true
        //else have a while loop that is !saveItem and goes through tree to find value
        // add a way for the loop to end when the value is found or if left or right == null;
        public bool Search(int valueToCheck)
        {
            bool saveItem = false;

            if (valueToCheck == root.data)
            {
                return true; //value found was the root 
            }
            else
            {
                while (!saveItem)
                {
                    Node currentNode = root; 

                    if(valueToCheck <= currentNode.data)
                    {
                        if(currentNode.left == null)
                        {
                            return false; //value was not found at left 
                        }
                        else if(valueToCheck == currentNode.left.data)
                        {
                            saveItem = true;//stops while loop found value
                            return true;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else   //checking right 
                    {
                        if(currentNode.right == null)
                        {
                            return false;
                        }
                        else if(valueToCheck == currentNode.right.data)
                        {
                            saveItem = true;
                            return true;
                        }
                        else
                        {
                            currentNode = currentNode.right; 
                        }
                    }
                }
            }
            return false;

        }
    }
}
