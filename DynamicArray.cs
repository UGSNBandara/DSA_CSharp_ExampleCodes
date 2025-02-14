using System;
using System.ComponentModel;


namespace DSA_CSharp
{
    public class DynamicArray
    {
        private int[] array;
        private int count;
        private int size;

        public DynamicArray()
        {
            array = new int[1];
            count = 0;
            size = 1;
        }

        //Print the Array
        public void PrintArray()
        {
            for (int i =0; i< count; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        //Add Element to Array
        public void AddElement(int newValue)
        {
            if (count == size)
            {
                GrowSize();
            }
            array[count] = newValue;
            count++;
        }

        //Add an Element at Given Index
        public void AddElementAt(int ind, int newValue)
        {
            if (ind > count || ind < 0)
            {
                Console.WriteLine("Index is OutofBound So add to the End of the Array");
                AddElement(newValue);
                return;
            }

            if (count == size)
            {
                GrowSize();
            }

            for (int i = count - 1; i >= ind; i--)
            {
                array[i + 1] = array[i];
            }

            array[ind] = newValue;
            count++;
        }

        //Grow the size of Array By *2
        private void GrowSize()
        {
            int[] temp = null;
            if (count == size)
            {
                temp = new int[size * 2];
                for (int i = 0; i < size; i++)
                {
                    temp[i] = array[i];
                }
                array = temp;
                size = size * 2;
            }
        }

        // To Remove extra spaces ( Srink Array)
        private void SrinkArray()
        {
            int[] temp = null;
            if (count > 0)
            {
                temp = new int[count];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = array[i];
                }

                array = temp;
                size = count;
            }
        }

        //Remove Element at the End
        public void RemoveAtEnd()
        {
            if (count > 0)
            {
                array[count - 1] = 0;
                count--;
            }
        }

        public void RemoveAt(int index) 
        {
            if (count > 0)
            {
                if( 0<=index || index < count)
                {
                    for(int i = index; i< count-1; i++)
                    {
                        array[i] = array[i + 1];
                    }
                }

                array[count - 1] = 0;
                count--;
            }
        }
    }
}
