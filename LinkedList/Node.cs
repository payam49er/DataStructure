using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    class Node
    {
        //value of the node
        public object Data { get; set; }
        //link of the node to the next node
        public Node Link { get; set; }

        //default constructor
        public Node(object dataValue)
            : this(dataValue, null)
        {
        }

        public Node(object dataValue, Node nextNode)
        {
            Data = dataValue;
            Link = nextNode;
        }
    } //End of class Node
           
}