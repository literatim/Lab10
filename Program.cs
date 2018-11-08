using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Circle Tester");
            List<Circle> circles = new List<Circle>();

            do
            {

                Console.Write("Enter a radius: ");
                double radius = GetUserInput();

                Circle circle = new Circle(radius);
                circles.Add(circle);

                string formattedCircumference = circle.CalculateFormattedCircumference();
                string formattedArea = circle.CalculateFormattedArea();

                Console.WriteLine($"Circumference: {formattedCircumference}");
                Console.WriteLine($"Area: {formattedArea}");


                Console.Write("Would you like to start again? (y/n): ");
            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"Goodbye. You created {circles.Count} Circle object(s).");
            Console.ReadKey();
            
        }

        private static double GetUserInput()
        {
            double formattedRadius;
            while (!double.TryParse(Console.ReadLine(), out formattedRadius))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.WriteLine("Please enter a radius: ");
            }

            return formattedRadius;
        }
    }
}
