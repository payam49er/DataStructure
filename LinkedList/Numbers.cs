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
        public SingleyLinkedList CreateList(string input)
        {


            SingleyLinkedList testlist = new SingleyLinkedList();
            var parsedvalues = int.Parse(input);
            string values = parsedvalues.ToString();
            char[] numbers = values.ToCharArray();

            foreach (char item in numbers)
            {
                int val = (int)char.GetNumericValue(item);
                testlist.InsertAtFront(val);

            }

            return testlist;

        }


        //method to add two linkedlist elements to each other, the return is in the form of a string 
        public SingleyLinkedList AddLists(SingleyLinkedList list1, SingleyLinkedList list2)
        {

            SingleyLinkedList finalValue = new SingleyLinkedList();
      
            
            // using Get and index is not going to work, I have to use Node and node.link to do the addition
           
            
            for (int i = 0; i < list1.Size(); i++)
            {

                int A = Convert.ToInt32(list1.GetValue(i));
                int B = Convert.ToInt32(list2.GetValue(i));

                int addedInts = A + B;
                int carryover = addedInts >= 10 ? 1 : 0;

                int noCarry = addedInts % 10;
                finalValue.InsertAtTail(noCarry);
                if (i + 1 < list1.Size())
                {
                    int C = Convert.ToInt32(list1.GetValue(i + 1));
                    int D = Convert.ToInt32(list2.GetValue(i + 1));
                    int addedCD = C + D + carryover;
                    finalValue.InsertAtTail(addedCD % 10);
                }
                else if (i + 1 >= list1.Size())
                {
                    
                    finalValue.InsertAtTail(addedInts);
                }
                

                
             }
            return finalValue;
                    

        }
        
    }
}
