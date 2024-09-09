using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    internal class Program
    {
        public static string IsPalindrome(string palindrome)
        {

            char[] chars = palindrome.ToCharArray();

            Array.Reverse(chars);

            string result = new string(chars);

            if (palindrome == result)
            {
                Console.WriteLine(palindrome + " is a palindrome!");
                Console.WriteLine("Enter a string: ");
                palindrome = Console.ReadLine();
                return palindrome;
            }
            else
            {
                Console.WriteLine(palindrome + " isn't a palindrome.");
                Console.WriteLine("Enter a string: ");
                palindrome = Console.ReadLine();
                return palindrome;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("CHECK PALINDROME");
            Console.WriteLine("Enter a string: ");
            string palindrome = Console.ReadLine();
            palindrome = palindrome.ToLower();

            while ( palindrome != "exit")
            {
                IsPalindrome(palindrome);
            }
            Console.WriteLine("Bye!");
            Console.ReadLine();
        }
    }
}
