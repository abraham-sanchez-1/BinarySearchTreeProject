using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        //member variable
        public int data { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }

        //constructor
        public Node(int data)
        {
            this.data = data;
        }

        //member method

    }
}
