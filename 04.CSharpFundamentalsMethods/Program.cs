using System;

namespace _04.CSharpFundamentalsMethods
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumber(number);

        }
        static void PrintNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");

            }else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");

            }else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
