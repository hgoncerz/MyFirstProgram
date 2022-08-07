using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            double x;
            double y;
            double result;
            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Enter only number ");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("you can't divde by zero idiot");

            }
            catch (Exception e)
            {
                Console.WriteLine("something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }


            Console.ReadLine();

        }
    
    }
}