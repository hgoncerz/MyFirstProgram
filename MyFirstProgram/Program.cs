using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine(Planets.Earth + "is a planet #"+(int)Planets.Earth);*/
            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;

            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Volume " + volume);
            Console.ReadKey();
        }
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
        
    }
    enum Planets
    {
        Mercury,
        Vnus,
        Earth
    }
    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6471
    }

}