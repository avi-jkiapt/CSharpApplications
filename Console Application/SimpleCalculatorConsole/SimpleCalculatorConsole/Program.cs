using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("-------------------Welcome To use Basic Calculator-------------------");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Here are some operation you can perform.");
            Console.WriteLine("1: Addition ");
            Console.WriteLine("2: Subtraction ");
            Console.WriteLine("3: Multiplication ");
            Console.WriteLine("4: Division ");
            Console.WriteLine("5: Quit Application");

            Console.WriteLine("Enter 1 for addition 2 for subtraction 3 for multiplication 4 for Division" +
                " and any other key for Quit");

            int n = Convert.ToInt32(Console.ReadLine());
            double a, b, result = 0;
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a + b;
                    Console.WriteLine("Result of two number is " + result);
                    break;
                case 2:
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine("Result of two number is " + result);
                    break;
                case 3:
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine("Result of two number is " + result);
                    break;
                case 4:
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a / b;
                    Console.WriteLine("Result of two number is " + result);
                    break;
                default:
                    Console.WriteLine("Exit Application");
                    break;
            }

            Console.ReadLine();
        }
    }
}
