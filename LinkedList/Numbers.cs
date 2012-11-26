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
            //create a buffeer linked list that contains only added numbers
            SingleyLinkedList bufferList = new SingleyLinkedList();
            SingleyLinkedList finalList = new SingleyLinkedList();

            //finding the bigger list size
            int sizeList1 = list1.Size();
            int sizeList2 = list2.Size();
            int biggerSize = Math.Max(sizeList1, sizeList2);
            //equalizing the size of both lists, making math operations easier
            if(sizeList1 > sizeList2)
            {
                for(int i=0; i<(sizeList1-sizeList2);i++)
                {

                list2.InsertAtTail(0);
                }
            }
            else if(sizeList2 > sizeList1)
            {
                for(int i=0; i <(sizeList2-sizeList1);i++)
                {
                list1.InsertAtTail(0);
                }
            }

            for (int i = 0; i < biggerSize; i++)
            {
                int A = Convert.ToInt32(list1.GetValue(i));
                int B = Convert.ToInt32(list2.GetValue(i));
                int AddedAB = A + B;
                bufferList.InsertAtTail(AddedAB);
            }
           // return bufferList;


            for (int i = 0; i < bufferList.Size(); i++)
            {
                int firstvalue = Convert.ToInt32(bufferList.GetValue(i));
                if (firstvalue >= 10)
                {
                    int carryOver = 1;
                    while (i + 1 <= bufferList.Size())
                    {
                        int nextValue = Convert.ToInt32(bufferList.GetValue(i + 1)) + carryOver;
                        finalList.InsertAtFront(nextValue);
                    }
                }
                else
                {
                    finalList.InsertAtFront(firstvalue);
                }
                
            }
            return finalList;
        }
        
    }
}
