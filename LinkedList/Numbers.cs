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
            //these two lines are just for testing 
            Console.WriteLine("This is the buffer list:");
            bufferList.Display(bufferList);
           // return bufferList;

            int carry = 0;
            for (int i = 0; i < bufferList.Size(); i++)
            {
                int sum = Convert.ToInt32(bufferList.GetValue(i))+carry;
                finalList.InsertAtFront(sum%10);
                carry =sum/10;
            }

               while(carry > 0)
               {
                   finalList.InsertAtFront(carry%10);
                   carry = carry / 10;
               }
            return finalList;
        }


        //this method subtracs two linked lists digits from each other, first list parameter has to be bigger than the second

        public SingleyLinkedList Subtrac(SingleyLinkedList list1, SingleyLinkedList list2)
        {
            
            SingleyLinkedList subtractionList = new SingleyLinkedList();
            
            //finding the bigger list size
            int sizeList1 = list1.Size();
            int sizeList2 = list2.Size();
            int biggerSize = Math.Max(sizeList1, sizeList2);
            //equalizing the size of both lists, making math operations easier
            if (sizeList1 > sizeList2)
            {
                for (int i = 0; i < (sizeList1 - sizeList2); i++)
                {

                    list2.InsertAtTail(0);
                }
            }
            else if (sizeList2 > sizeList1)
            {
                for (int i = 0; i < (sizeList2 - sizeList1); i++)
                {
                    list1.InsertAtTail(0);
                }
            }

            int carry = 0;
            for (int i = 0; i < biggerSize; i++)
            {
                int A = Convert.ToInt32(list1.GetValue(i))+carry;
                int B = Convert.ToInt32(list2.GetValue(i));
                if (A < B)
                {
                    A = A + 10;
                    carry = -1;
                }
                else
                {
                    carry = 0;
                }

                int SubtractedAB = A - B;
                subtractionList.InsertAtFront(SubtractedAB);
            }
            return subtractionList;
        }
           
        // this method multiplies two numbers that are held in singly linked list
        public SingleyLinkedList Multiply(SingleyLinkedList list1, SingleyLinkedList list2)
        {
            SingleyLinkedList finalList = new SingleyLinkedList();
            int carry = 0;
            for (int i = 0; i < list2.Size(); i++)
            {

                int A = Convert.ToInt32(list2.GetValue(i));
                for (int j = 0; j < list1.Size(); j++)
                {
                    int multi = (A * (Convert.ToInt32(list1.GetValue(j))))+carry;
                    
                    if (multi >= 10)
                    {
                        carry = 10;
                        int result = multi % 10;
                    }
                    else
                    {
                        carry = 0;
                    }


                    finalList.InsertAtFront(multi);
                    
                }

                while (carry > 0)
                {
                    finalList.InsertAtFront(carry % 10);
                    carry = carry / 10;
                }
            }

         
            return finalList;
        }
    }
}
