using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
          int x;//declaration
            x = 123; //initialization
            int y = 321;

            int z = x + y;

            int age = 21;
            double height = 300.5;
            bool alive = true;
            char symbol = '@';
            String name = "Bro";

            Console.WriteLine("Hello " + name);


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("your age is " + age);
            Console.WriteLine("Your height is " + height + " cm");
            Console.WriteLine("Are you alive? "+ alive);
            Console.WriteLine("Your symbol is: " + symbol);

            String userName = symbol + name;
            Console.WriteLine("YOur username is: " + userName);

            Console.ReadKey();


        }
    }
}