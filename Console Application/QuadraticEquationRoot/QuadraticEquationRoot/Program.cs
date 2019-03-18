using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d, x1, x2;
            Console.WriteLine("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
                 
            Console.WriteLine("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of c: ");
            c = Convert.ToInt32(Console.ReadLine());
            d = b * b - 4 * a * c;
            if(d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine("Value of roots are : {0} and {1}", x1, x2);

            }else if (d < 0)
            {
                Console.WriteLine("Roots are Imaginary.");
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Roots are {0} and {1}.", x1, x2);

            }
            Console.ReadKey();
        }
    }
}
