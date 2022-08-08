using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            car.go();
            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);

            bicycle.go();
            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
                        
            boat.go();
            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);


            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle: Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }

}