using System;

namespace MyFirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            // return = returns data back to the place where a method is invoked
            double x;
            double y;
            double result;

            // Allows user to enter number 1
            Console.WriteLine("Enter a number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            // Allows user to enter number 2
            Console.WriteLine("Enter a number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine(result);
            Console.ReadKey();

        }
        static double Multiply(double x, double y)
        {
            double z = x * y;
            return z;

            // Return X * Y
        }
    }
    }