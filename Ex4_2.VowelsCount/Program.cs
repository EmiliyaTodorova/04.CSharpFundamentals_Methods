using System;
using System.Linq;

namespace Ex4_2.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            SearchForVowels(inputText);
            
        }

        private static void SearchForVowels(string inputText)
        {
            Console.WriteLine(inputText.Count(text => "aouei".Contains(text)));
        }
    }
}
