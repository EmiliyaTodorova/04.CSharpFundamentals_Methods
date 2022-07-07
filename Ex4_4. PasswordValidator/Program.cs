using System;

namespace Ex4_4._PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordLengthValid = ValidatePasswordLength(password);
            bool isPasswordContainValidSymbols = ValidatePasswordSymbols(password);
            bool isDigitsInPasswordAtLeast2 = ValidatePasswordDigits(password);

            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordContainValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isDigitsInPasswordAtLeast2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(isPasswordLengthValid && isPasswordContainValidSymbols && isDigitsInPasswordAtLeast2)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool ValidatePasswordDigits(string password)
        {
            int count = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count >= 2;
        }

        private static bool ValidatePasswordSymbols(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidatePasswordLength(string password)
        {
            return password.Length >=6 && password.Length <=10;
            
        }
    }
}
