using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> food = new List<String>();
            food.Add("fries");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            Console.WriteLine(food.LastIndexOf("fries"));

            Console.WriteLine(food.Contains("pizza"));

            //food.Sort();
            //food.Reverse();

            //food.Clear();

            //food.Remove("fries");
            //food.Insert(0, "sushi");

            //Console.WriteLine(food.Count);

            //Console.WriteLine(food.IndexOf("pizza"));

            String[] foodArray = food.ToArray();

            foreach(String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        
    }

}