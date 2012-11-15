using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class SingleyLinkedList
    {
        private Node firstNode;
        private Node lastNode;
        private string name; // to dispay the name of the list

        //constructing empty list
        public SingleyLinkedList(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        //construct empty list with list as its name
        public SingleyLinkedList()
            : this("list")
        {
        }

        //method to insert object in to the list
        //if list is empty, first and last node are the same
        //if not empty, first node refers to new node

        public void InsertAtFront(object item)
        {
            if (firstNode == null)
            {
                firstNode = lastNode = new Node(item);
            }
            else
            {
                firstNode = new Node(item, firstNode);
            }

        } // end of InsertAtFront method


        // Method to insert item at the tail of the list

        public object InsertAtTail(object item)
        {
            if (firstNode == null && lastNode == null)
            {
                firstNode = lastNode = new Node(item);
            }
            else
            {
                lastNode = lastNode.Link = new Node(item);
            }

            return lastNode;
        } //end of insertAtTail method


        // method to remove first node from the list
        public object removeFromFront()
        {
            if (firstNode == null)
            {
                throw new Exception("The list is empty");
            }

            object removeItem = firstNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Link;
            }

            return removeItem;
        }

        //method to remove last item from the list
        public object removeFromTail()
        {
            if (firstNode == null)
            {
                throw new Exception("This list is empty");
            }

            object removeItem = lastNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                Node current = firstNode;
                while (current.Link != lastNode)
                {
                    current = current.Link;
                }

                lastNode = current;
                current.Link = null;

            }

            return removeItem;
        }


        //Display list content 
        public void Display(SingleyLinkedList mylist)
        {
            if (mylist.firstNode == null)
            {
                Console.WriteLine("The list {0} is empty", name);
            }
            else
            {
                Node current = mylist.firstNode;
                //outputing current node data 
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Link;
                }

                Console.WriteLine("\n");
            }

        }

        //method to count the number of nodes in the list

        public int Size()
        {
            Node current = firstNode;
            if (firstNode != null)
            {
                var numNodes = 1; //there is atleast on node 
                while (current != null)
                {
                    numNodes++;
                    current = current.Link;

                }
                return (numNodes - 1);
            }

            else
            {
                Console.WriteLine("Your list {0} is empty", name);
            }

            return 0;

        }
              
        //method to multiply elements of the one list together

        public void MultiplyOneList()
        {
            Node current = firstNode;
            if (firstNode != null)
            {
                //the details of your multiplication method
                while (current != null)
                {
                    var multiple = current.Data;
                }

            }
            else
            {
                Console.WriteLine("Your list {0} is empty!", name);
            }
        }



    } // end of class SingleyLinkedList
}