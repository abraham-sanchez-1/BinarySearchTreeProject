using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTreeClass binarySearchTree = new BinarySearchTreeClass();
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(8);
            binarySearchTree.Insert(-3);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(1);
            binarySearchTree.Insert(2);
            binarySearchTree.Insert(9);
            binarySearchTree.Insert(-5);
            binarySearchTree.Insert(-6);
            binarySearchTree.Search(-4);

        }
    }
}
