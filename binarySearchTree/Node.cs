using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Node
    {
        //Member Variables
        public int data;
        public Node left;
        public Node right;
       

        //Constructor
        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;    
        }
    }
}
