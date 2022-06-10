using System;

namespace ClassExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Ram";
            car.Model = "TRX";
            car.Year = "2023"; 

            Console.WriteLine($"Car Make, Model, & Year");
            Console.WriteLine($"-----------------------------------------");
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
        }
    }
}
