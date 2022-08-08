using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car =  new Car();
            Bicycle bicycle = new Bicycle();    
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, bicycle, boat };

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
           

            Console.ReadKey();
        }
        
    }
    class Vehicle
    {
        public virtual void Go()
        {

        }
    }
    class Car:Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is movieng! ");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is movieng! ");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is movieng! ");
        }
    }

}