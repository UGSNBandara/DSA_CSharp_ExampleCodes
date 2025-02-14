using System;

namespace DSA_CSharp
{


    class Program
    {
        static void Main()
        {
            //since the TestDynamicArray is not a staticMethod, we need to create an object and access instance method inside the Static methods
            Program p = new Program();
            p.TestDynamicArray();
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
    }
}