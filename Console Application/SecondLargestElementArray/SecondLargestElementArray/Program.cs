using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of values: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array Values: ");
            for (int i=0; i < n; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
            }
             
            //Sort array value in increasing order
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            //Sorted Array
            for(int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("Second Largest Value in the array is " + array[n - 2]);

            Console.ReadKey();
        }
    }
}
