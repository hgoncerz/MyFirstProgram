using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name);


            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age " + age + "years old");
            Console.ReadKey();


        }
    }
}