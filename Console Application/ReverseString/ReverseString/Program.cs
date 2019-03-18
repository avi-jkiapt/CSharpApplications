using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Original String: ");
            String str = Console.ReadLine();

            Console.WriteLine("Original String is: ");
            Console.WriteLine(str);
            String reverseStr = "";

            int length = str.Length;
            for(int i = length-1; i >=0; i--)
            {
                reverseStr += str[i];
            }
            Console.WriteLine("Reverse String is: ");
            Console.WriteLine(reverseStr);
            Console.ReadKey();
        }
    }
}
