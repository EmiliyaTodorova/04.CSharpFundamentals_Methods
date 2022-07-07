using System;

namespace Ex4_1.SmalestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(MinNumber(num1, num2, num3));
        }
        static int MinNumber(int a, int b, int c)
        {
            return (Math.Min(a, Math.Min(b, c)));
        }
    }
}
