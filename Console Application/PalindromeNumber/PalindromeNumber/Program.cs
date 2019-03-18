using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int k = n;
            int r, s=0;
            while (n > 0)
            {
                r = n % 10;
                s = s*10 + r;
                n = n / 10;
            }
            if (k == s)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }

            Console.ReadKey();
        }
    }
}
