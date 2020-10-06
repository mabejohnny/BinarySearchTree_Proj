using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree addToTree = new BinarySearchTree();
            addToTree.Add(100);
            addToTree.Add(50);
            addToTree.Add(120);
            addToTree.Add(25);

            addToTree.Search(25);

        }
    }
}
