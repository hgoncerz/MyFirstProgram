using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello enter a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter b");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            Console.WriteLine("Result is: "+c);

            Console.ReadKey();


        }
    }
}