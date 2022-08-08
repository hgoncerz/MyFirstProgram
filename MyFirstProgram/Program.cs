using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            fish.Flee();
            fish.Hunt();

            hawk.Hunt();

            rabbit.Flee();

            Console.ReadKey();
        }
        
    }
    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }
   class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }       
    }
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food");
        }
    }
    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish");
        }
    }

}