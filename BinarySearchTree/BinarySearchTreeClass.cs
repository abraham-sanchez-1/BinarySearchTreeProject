using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTreeClass
    {
        //member variable
        Node start;
        Node recent;

        //constructor
        public BinarySearchTreeClass()
        {
            start = null;
          
        }
        //member method
        public void InsertAtEnd(int data)
        {
            if (start == null)
            {
                start = new Node(data);
            }
        }
    }
}
