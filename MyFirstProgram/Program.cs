using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
        }
        
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes brr");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes woof!");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes mial");
        }
    }


}