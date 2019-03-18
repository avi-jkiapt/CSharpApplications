using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter order of Ist Matrix: ");
            Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter order of IInd Matrix: ");
            Console.Write("p: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("q: ");
            int q = Convert.ToInt32(Console.ReadLine());

            if (n != p)
            {
                Console.WriteLine("The Given Order Matrix Cannot be Multiplied. ");
            }
            else
            {
                int[,] a = new int[m, n];
                int[,] b = new int[p, q];

                Console.WriteLine("Enter First Matrix: ");
                int i, j, k;
                for (i = 0; i < m; i++)
                {
                    Console.WriteLine("Enter {0}th row: ", i+1);
                    for (j = 0; j < n; j++)
                    {
                        int value = Convert.ToInt32(Console.ReadLine());
                        a[i, j] = value;
                    }
                }
                Console.WriteLine("Enter Second Matrix: ");
                for (i = 0; i < m; i++)
                {
                    Console.WriteLine("Enter {0}th row: ", i + 1);
                    for (j = 0; j < n; j++)
                    {
                        int value = Convert.ToInt32(Console.ReadLine());
                        b[i, j] = value;
                    }
                }

                int[,] c = new int[m, q];
                //Multiply
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        c[i, j] = 0;
                        for (k = 0; k < q; k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                //print
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        Console.Write(c[i, j] + " ");
                    }
                    Console.WriteLine();
                }



            }
            Console.Read();
        }
    }
}
