﻿using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {


                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("______________");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("______________");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("+ : Add");
                Console.WriteLine("- :Subtract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your resutl: {num1}+ {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your resutl: {num1}- {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your resutl: {num1}* {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your resutl: {num1}/ {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y/N)");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");



            Console.ReadKey();


        }
    }
}