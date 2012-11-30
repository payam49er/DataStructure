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

           // //these two lines are just for testing 
           // Console.WriteLine("This is the buffer list:");
           // bufferList.Display(bufferList);
           //// return bufferList;

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
            SingleyLinkedList finalList = new SingleyLinkedList();
            //finding the bigger list size
            
            int biggerSize = Math.Max(list1.Size(),list2.Size());
            int carry = 0;
            for (int i = 0; i < biggerSize; i++)
            {
              
               if (list2.GetValue(i) == null)
               {
                   int A = Convert.ToInt32(list1.GetValue(i))+carry;
                   subtractionList.InsertAtFront(A);
                   carry = 0;
               }

               if (list1.GetValue(i) !=null && list2.GetValue(i) !=null)
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
                   subtractionList.InsertAtFront(A-B);
               }
            }
           
            return subtractionList;
        }
 
           
        // this method multiplies two numbers that are held in singly linked list, assuming list1 has more digits than list2 
        public SingleyLinkedList Multiply(SingleyLinkedList list1, SingleyLinkedList list2)
        {
            SingleyLinkedList multiplyList = new SingleyLinkedList();
            SingleyLinkedList tempList1 = new SingleyLinkedList();
            SingleyLinkedList tempList2 = new SingleyLinkedList();
          
            for (int j = 0; j < list2.Size(); j++)
            {
                int carry = 0;
                int B = Convert.ToInt32(list2.GetValue(j));
                
                for (int k = 0; k < list1.Size(); k++)
                {
                    
                    int A = Convert.ToInt32(list1.GetValue(k));
                   
                    if (k == list1.Size()-1)
                    {
                        int multiply = ((A * B) + carry);
                        multiplyList.InsertAtFront(multiply);
                        carry = 0;
                    }
                    if (k < list1.Size()-1)
                    {
                        int multiply = ((A * B) + carry) % 10;
                        multiplyList.InsertAtFront(multiply);
                        carry = 0;
                    }
                    carry = (int)((A * B) / 10);
                }
            }
          //return multiplyList;
         
            for ( int t = 0 ; t < list2.Size() ; t++)
            {

                for (int n = 0; n < list1.Size(); n++)
                {
                    int val = Convert.ToInt32(multiplyList.GetValue(n));
                    tempList1.InsertAtFront(val);
                }
                
                                
                for (int m = 0; m < list2.Size() - 1; m++)
                {
                    tempList1.InsertAtFront(0);
                }
                
            }

            return tempList1;
            
              


        }
        
    }
}
