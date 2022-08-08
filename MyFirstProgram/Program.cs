using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage1 = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

        foreach(Car car in garage1)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }


}