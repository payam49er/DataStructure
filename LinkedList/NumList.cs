using System;
using LinkedList;

namespace LinkedList
{
    //main class to do take numbers in, make a linkedlist of them, and do arithmatic operations on them
    public class NumList
    {
        public static void Main()
        {

            Numbers mylist = new Numbers();
            Console.WriteLine("Please insert your first list of numbers:");
            string input1 = Console.ReadLine();
            var firstvalues = mylist.CreateList(input1);


            Console.WriteLine("The elements in the list are:");
            mylist.Display(firstvalues);

            Console.WriteLine("Please insert your second list of numbers:");
            string input2 = Console.ReadLine();
            var secondvalues = mylist.CreateList(input2);
            Console.WriteLine("The elements in your second list are:");
            mylist.Display(secondvalues);

            var count = firstvalues.Size();
            Console.WriteLine("the size of first list is:{0}", count);

            var secondcount = secondvalues.Size();
            Console.WriteLine("the size of second list is:{0}", secondcount);

            //var indexedvalue = firstvalues.Get(2);
            //Console.WriteLine("the value of index 2 is:{0}", indexedvalue);

           //add the list to each other
             SingleyLinkedList result = mylist.AddLists(firstvalues, secondvalues);
             Console.WriteLine("The addition result is:");
             result.Display(result);


           Console.ReadLine();

        }
    }
}