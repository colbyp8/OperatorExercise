using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            var b = int.Parse(Console.ReadLine());

            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("Enter the radius of the circle: ");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius: {radius} is {area}.");

        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
