using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            cars[0] = "Opel";

            int[] nums = { 35, 15, 24, 32 };

            Console.WriteLine(cars[2]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);


            string[] models = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(models[2]);
        }
    }
}
