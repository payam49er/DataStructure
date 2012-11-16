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
            string input = Console.ReadLine();
            var myvalues = mylist.CreateListNumber(input);


            Console.WriteLine("The elements in the list are:");
            mylist.Display(myvalues);

            Console.WriteLine("Please insert your second list of numbers:");
            string secondinput = Console.ReadLine();
            var secondvalues = mylist.CreateListNumber(secondinput);
            Console.WriteLine("The elements in your second list are:");
            mylist.Display(secondvalues);

            var count = myvalues.Size();
            Console.WriteLine("the size of first list is:{0}", count);

            var secondcount = secondvalues.Size();
            Console.WriteLine("the size of second list is:{0}", secondcount);

            Console.ReadLine();

        }
    }
}