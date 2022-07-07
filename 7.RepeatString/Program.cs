using System;
using System.Text;

namespace _7.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string template = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(template, repeatTimes));
        }

        static string RepeatString(string template, int countRepeat)
        {
            StringBuilder result = new StringBuilder();
            for(var i = 0; i < countRepeat; i++)
            {
                result.Append(template);
            }
            return result.ToString();

        }
    }
}
