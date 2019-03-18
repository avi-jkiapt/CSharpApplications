using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            //Command Line Argument Passing
            /*
              If you want to Pass Argumnets through Command Line then you can follow these steps.
               a-> Right Click on Project from Solution Explorer and Select Properties.
               b-> In the Project Properties Windows, Navigate to “Debug Tab”
               c-> You will Find the a text box “Command Line”
             Here you can type the command line with separated by Space in the given Dialog Box. 

            */

            //Iterate through Each Arguments passed
            for(int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i] + " ");
            }

            Console.WriteLine("Thank you for using Command Line Arguments.");
            Console.ReadKey();
        }
    }
}
