using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    // this class works on numbers that we recieve as input. creating a list of them and doing
    //mathematical operations of addition, multiplicaton and subtraction
    class Numbers : SingleyLinkedList
    {
      
   
        // This method accept numbers read from the console and places them in to a linkedlist that payam has created
        public SingleyLinkedList CreateListNumber(string input)
        {
            

            SingleyLinkedList testlist = new SingleyLinkedList();
            var parsedvalues = int.Parse(input);
            string values = parsedvalues.ToString();
            char[] numbers = values.ToCharArray();

            foreach (char item in numbers)
            {
                int val = (int)char.GetNumericValue(item);
                testlist.InsertAtTail(val);
               
            }

            return testlist;

        }
    }
}
