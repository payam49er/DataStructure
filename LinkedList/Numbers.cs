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


        //method to add two linkedlist elements to each other, the return is in the form of a string , list1 has to be equal or bigger in size than link2
        public SingleyLinkedList AddLists(SingleyLinkedList list1, SingleyLinkedList list2)
        {
            //create a buffeer linked list that contains only added numbers
            SingleyLinkedList bufferList = new SingleyLinkedList();
            SingleyLinkedList finalList = new SingleyLinkedList();

            //finding the bigger list size
            int sizeList1 = list1.Size();
            int sizeList2 = list2.Size();
            int biggerSize = Math.Max(sizeList1, sizeList2);
         
            int sizeDiff = Math.Abs(list1.Size() - list2.Size());

            if (sizeDiff == 0)   //both lists are of the same size
                {
                  for(int i =0 ; i < biggerSize; i++)
                      {
                         int A = Convert.ToInt32(list1.GetValue(i));
                         int B = Convert.ToInt32(list2.GetValue(i));
                         bufferList.InsertAtTail(A + B);
                      }
                }                       
                 
            //when the lists are not of the same size

            if (sizeDiff != 0)
            {

                for (int i = 0; i < biggerSize; i++)
                {
                    if (list1.GetValue(i) == null)
                    {
                        int B = Convert.ToInt32(list2.GetValue(i));
                        bufferList.InsertAtTail(B);
                    }
                    if (list2.GetValue(i) == null)
                    {
                        int A = Convert.ToInt32(list1.GetValue(i));
                        bufferList.InsertAtTail(A);
                    }
                    if (list1.GetValue(i) != null && list2.GetValue(i) != null)
                    {
                        int A = Convert.ToInt32(list1.GetValue(i));
                        int B = Convert.ToInt32(list2.GetValue(i));
                        bufferList.InsertAtTail(A + B);
                    }
                }
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

        public SingleyLinkedList Subtrac(SingleyLinkedList list3, SingleyLinkedList list4)
        {
            
            SingleyLinkedList subtractionList = new SingleyLinkedList();
            
            //finding the bigger list size
            int sizeList3 = list3.Size();
            int sizeList4 = list4.Size();
            int biggerSize = Math.Max(sizeList3, sizeList4);
            //equalizing the size of both lists, making math operations easier
            if (sizeList3 > sizeList4)
            {
                for (int i = 0; i < (sizeList3 - sizeList4); i++)
                {

                    list4.InsertAtTail(0);
                }
            }
            else if (sizeList4 > sizeList3)
            {
                for (int i = 0; i < (sizeList4 - sizeList3); i++)
                {
                    list3.InsertAtTail(0);
                }
            }

            int carry = 0;
            for (int i = 0; i < biggerSize; i++)
            {
                int A = Convert.ToInt32(list3.GetValue(i))+carry;
                int B = Convert.ToInt32(list4.GetValue(i));
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
        public SingleyLinkedList Multiply(SingleyLinkedList list5, SingleyLinkedList list6)
        {
            SingleyLinkedList tempList = new SingleyLinkedList();
            int carry = 0;
            for (int i = 0; i < list6.Size(); i++)
            {

                int A = Convert.ToInt32(list6.GetValue(i));

                for (int j = 0; j < list5.Size(); j++)
                {
                    int multi = (A * (Convert.ToInt32(list5.GetValue(j))))+carry;
                    
                    if (multi >= 10)
                    {
                        carry = 1;
                        int result = multi % 10;
                        tempList.InsertAtFront(result);
                    }
                    else
                    {
                        carry = 0;
                        tempList.InsertAtFront(multi);
                    }
                                    
                    
                }

            }

         
            return tempList;
        }
    }
}
