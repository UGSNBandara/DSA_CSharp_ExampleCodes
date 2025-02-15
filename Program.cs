using System;

namespace DSA_CSharp
{


    class Program
    {
        static void Main()
        {
            //since the TestDynamicArray is not a staticMethod, we need to create an object and access instance method inside the Static methods
            Program p = new Program();
            //p.TestSinglyLinkedList();
            //p.TestDynamicArray();
            p.TestDoubleyLinedList();
        }


        // Test Dynamic Array Class
        private void TestDynamicArray()
        {
            DynamicArray darray = new DynamicArray();
            darray.AddElement(10);
            darray.AddElement(20);
            darray.AddElement(30);
            darray.AddElement(40);

            darray.PrintArray();

            darray.AddElementAt(1, 15);
            darray.AddElementAt(3, 25);

            darray.PrintArray();

            darray.RemoveAt(0);
            darray.RemoveAt(2);

            darray.PrintArray();
        }

        private void TestSinglyLinkedList()
        {
            Singly_LinkedList<int> sLs = new Singly_LinkedList<int>();
            sLs.AddLast(10);
            sLs.AddLast(20);
            sLs.AddFirst(30);
            sLs.AddFirst(40);
            sLs.AddLast(30);
            sLs.AddLast(40);
            sLs.AddLast(50);
            sLs.PrintList();

            sLs.AddFirst(5);
            sLs.PrintList();

            sLs.AddAtIndex(15, 2);
            sLs.PrintList();

            sLs.RemoveFirst();
            sLs.RemoveLast();
            sLs.PrintList();

            sLs.RemoveAtIndex(1);
            sLs.PrintList();

            sLs.RemoveByValue(30);
            sLs.PrintList();
        }

        private void TestDoubleyLinedList()
        {
            Doubley_LinkedList<int> dbLs = new Doubley_LinkedList<int>();

            dbLs.AddFirst(10);
            dbLs.AddLast(20);
            dbLs.AddFirst(30);
            dbLs.AddLast(15); 
            dbLs.AddFirst(30);
            dbLs.AddLast(30);
            dbLs.AddFirst(40);
            dbLs.AddLast(55);
            dbLs.AddFirst(360);
            dbLs.AddLast(12);

            dbLs.PrintListForward();
            dbLs.PrintListReverse();

            dbLs.RemoveLast();
            dbLs.RemoveFirst();

            dbLs.PrintListForward();

            dbLs.AddAtIndex(2, 154);
            dbLs.PrintListForward();

            dbLs.RemoveAtIndex(2);
            dbLs.PrintListForward();

        }
    }
}