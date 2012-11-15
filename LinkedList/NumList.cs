using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
          
         
            Console.WriteLine("The elements on the list are:{0}",myvalues);

            var count = myvalues.Size();
            Console.WriteLine("the size of list is:{0}", count);
         
            
            Console.ReadLine();
            
        }
    }
}
