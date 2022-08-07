using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //string interpolation

            String firstName = "Bro";
            String lastName = "Code";
            int age = 21;
            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age,-10} years old.");
            Console.ReadLine();

        }
    
    }
}