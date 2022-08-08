using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args) { 
            Car car1 = new Car("Mustang");
        Car car2 = new Car("Corvette");
            Car car3 = new Car("Corvette");

            Console.WriteLine(Car.numberOfCars);
            Car.StartRade();
            Console.WriteLine("test");

            Console.ReadLine();

        }
    
    }
    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
        this.model = model;
            numberOfCars++;
        }

        public static void StartRade()
        {
            Console.WriteLine("The race has begun! ");
        }
      
    }
  
}