using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElemnts(intArray);
            displayElemnts(doubleArray);
            displayElemnts(stringArray);

            Console.ReadKey();
        }
        public static void displayElemnts<Thing>(Thing[] array)
        {
           foreach(Thing item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
       
        
    }


}