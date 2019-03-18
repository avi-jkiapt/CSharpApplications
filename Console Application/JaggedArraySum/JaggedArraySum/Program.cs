using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySum
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Jagged Arrays");
            int[][] jagged = new int[3][];
            Console.Write("Enter Size of first inner Array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Size of Second inner Array: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Size of Third inner Array: ");
            int c = Convert.ToInt32(Console.ReadLine());
            jagged[0] = new int[a];
            jagged[1] = new int[b];
            jagged[2] = new int[c];

            Console.WriteLine("Enter first Array");
            for(int i = 0; i < a; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                jagged[0][i] = value;
            }
            Console.WriteLine("Enter Second Array");
            for (int i = 0; i < b; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                jagged[1][i] = value;
            }
            Console.WriteLine("Enter Third Array");
            for (int i = 0; i < c; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                jagged[2][i] = value;
            }

            //Sum
            int sum = 0;
            for(int i = 0; i < jagged.Length; i++)
            {
                for(int j=0;j< jagged[i].Length; j++)
                {
                    sum += jagged[i][j];
                }

            }

            Console.WriteLine("Sum of All : {0}", sum);
            Console.ReadKey();


        }
    }
}
