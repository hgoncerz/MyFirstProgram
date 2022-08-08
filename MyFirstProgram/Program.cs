using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Chevy", "Corvette", 2022, "Blue");

            Console.WriteLine(car);

            Console.ReadKey();
        }
        
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {

            String message = "This is a " + make + " " + model;
            return message;
        }
    }


}