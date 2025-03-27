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
            //p.TestDoubleyLinedList();
            //p.TestArrayStack();
            //p.TestLinkedListStack();
            //p.TestLinkedListArray_Graph();
            p.TestBST();
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

        private void TestArrayStack()
        {
            StackUsingArray<int> stack = new StackUsingArray<int>(10);
            stack.Push(45);
            stack.Push(55);
            stack.Push(65);
            stack.Push(75);
            stack.Push(85);
            stack.Push(95);
            stack.Push(105);
            stack.Push(115);
            stack.Push(125);

            stack.PrintStack();

            stack.pop();
            stack.pop();

            stack.Push(135);
            stack.Peek();

            stack.Push(145);
            stack.Peek();

            stack.PrintStack();
        }

        private void TestLinkedListStack()
        {
            //This is a Dynamic Stack, so the size is not fixed
            StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();
            stack.Push(45);
            stack.Push(55);
            stack.Push(65);
            stack.Push(75);
            stack.Push(85);
            stack.Push(95);
            stack.Push(105);
            stack.Push(115);
            stack.Push(125);

            stack.PrintStack();

            stack.Pop();

            stack.Push(135);
            stack.Peek();

            stack.Push(145);
            stack.Peek();

            stack.PrintStack();

        }

        private void TestLinkedListArray_Graph()
        {
            GraphWightedAndDirected graph = new GraphWightedAndDirected(5);

            graph.AddNewEdge(0, 1, 10);
            graph.AddNewEdge(0, 4, 20);
            graph.AddNewEdge(1, 2, 30);
            graph.AddNewEdge(1, 3, 40);
            graph.AddNewEdge(1, 4, 50);
            graph.AddNewEdge(2, 3, 60);
            graph.AddNewEdge(3, 4, 70);
            graph.AddNewEdge(4, 0, 80);

            graph.PrintGraph();
        }

        private void TestBST()
        {
            BST bst = new BST();

            bst.Insert(10);
            bst.Insert(20);
            bst.Insert(5);
            bst.Insert(15);
            bst.Insert(30);
            bst.Insert(25);
            bst.Insert(35);
            bst.Insert(40);
            bst.Insert(45);
            bst.Insert(50);

            bst.Print();

        }
    }
}