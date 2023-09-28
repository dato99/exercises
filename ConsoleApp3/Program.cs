using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static bool IsPalindrome(string text)
        {
            text = text.Replace(" ", " ").ToLower();
            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (text[left] != text[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            if (IsPalindrome(text))
            {
                Console.WriteLine("\"" + text + "\" is a palindrome.");
            }
            else
            {
                Console.WriteLine("\"" + text + "\" is not a palindrome.");
            }

        }
    }
}
